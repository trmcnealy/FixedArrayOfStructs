using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
    public sealed class Utf8StringEqualityComparer<NSize> : IEqualityComparer<utf8string<NSize>>
        where NSize : Const.IUInt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Utf8StringEqualityComparer()
        {
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(utf8string<NSize> x, utf8string<NSize> y)
        {
            return x.Equals(y);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int GetHashCode(utf8string<NSize> key)
        {
            unsafe
            {
                return key.Value == null ? 0 : key.GetHashCode();
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct utf8string<NSize> : IDisposable, IEquatable<utf8string<NSize>>, IComparable<utf8string<NSize>>, IComparable<string>
        where NSize : Const.IUInt
    {
        public static readonly utf8string<NSize>                    Null             = new((string?)null);
        public static readonly IEqualityComparer<utf8string<NSize>> EqualityComparer = new Utf8StringEqualityComparer<NSize>();

        public sbyte* Value;

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return (int)NSize.Value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public utf8string()
        {
#if NET6_0_OR_GREATER
            Value = (sbyte*)NativeMemory.AllocZeroed(NSize.Value + 1);
#else
            Value  = (sbyte*)Marshal.AllocHGlobal(NSize.Value + 1);
#endif

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public utf8string(utf8string<NSize> value)
        {
#if NET6_0_OR_GREATER
            Value = (sbyte*)NativeMemory.AllocZeroed(NSize.Value + 1);
#else
            Value  = (sbyte*)Marshal.AllocHGlobal(NSize.Value + 1);
#endif

            System.Buffer.MemoryCopy(value.Value,
                                     Value,
                                     Length,
                                     Length);

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public utf8string(utf8string value)
        {
#if NET6_0_OR_GREATER
            Value = (sbyte*)NativeMemory.AllocZeroed(NSize.Value + 1);
#else
            Value  = (sbyte*)Marshal.AllocHGlobal(NSize.Value + 1);
#endif
            long bytesToCopy = Math.Min(Length, value.Length);

            System.Buffer.MemoryCopy(value.Value,
                                     Value,
                                     bytesToCopy,
                                     bytesToCopy);

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public utf8string(sbyte* value)
        {
#if NET6_0_OR_GREATER
            Value = (sbyte*)NativeMemory.AllocZeroed(NSize.Value + 1);
#else
            Value  = (sbyte*)Marshal.AllocHGlobal(NSize.Value + 1);
#endif
            long bytesToCopy = Math.Min(Length, GetLength(value));

            System.Buffer.MemoryCopy(value,
                                     Value,
                                     bytesToCopy,
                                     bytesToCopy);

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public utf8string(string? value)
        {
            if (value == null)
            {
                Value = null;
                return;
            }

            if (value.Length == 0)
            {
#if NET6_0_OR_GREATER
                Value = (sbyte*)NativeMemory.AllocZeroed(1);
#else
                Value  = (sbyte*)Marshal.AllocHGlobal(1);
#endif
                Value[0] = 0;
                return;
            }

            if (value[^1] != char.MinValue)
            {
                value += char.MinValue;
            }
            
#if NET6_0_OR_GREATER
            Value = (sbyte*)NativeMemory.AllocZeroed(NSize.Value + 1);
#else
            Value  = (sbyte*)Marshal.AllocHGlobal(Length + 1);
#endif
            long bytesToCopy = Math.Min(Length, value.Length);

            byte[] bytes = Encoding.ASCII.GetBytes(value);

            for (int i = 0; i < bytesToCopy; i++)
            {
                Value[i] = (sbyte)bytes[i];
            }

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose()
        {
            DisposeUnmanaged();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private void DisposeUnmanaged()
        {
            if (Value is not null)
            {
#if NET6_0_OR_GREATER
                NativeMemory.Free(Value);
#else
                Marshal.FreeHGlobal((IntPtr)Value);
#endif
            }
        }

        public sbyte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return Value[index];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                Value[index] = value;
            }
        }

        public sbyte this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return Value[index];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                Value[index] = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int GetLength(sbyte* str)
        {
            if (str is null || str[0] == char.MinValue)
            {
                return 0;
            }

            sbyte* value = str;

            int length = 0;

            while (*value++ != char.MinValue)
            {
                ++length;
            }

            return length;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int CompareTo(utf8string<NSize> other)
        {
            if (other.Value is null)
            {
                return 1;
            }

            return Compare(this,
                           other.Value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int CompareTo(sbyte* other)
        {
            if (other is null)
            {
                return 1;
            }

            return Compare(this,
                           other);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int CompareTo(string? other)
        {
            if (other is null)
            {
                return 1;
            }

            return Compare(this,
                           other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Compare(utf8string<NSize> lhs,
                                  utf8string<NSize> rhs)
        {
            int ret = 0;

            byte* src = (byte*)lhs.Value;
            byte* dst = (byte*)rhs.Value;

            while ((ret = *src - *dst) == 0 && *dst != 0)
            {
                ++src;
                ++dst;
            }

            return (-ret < 0 ? 1 : 0) - (ret < 0 ? 1 : 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Compare(sbyte*     lhs,
                                  utf8string<NSize> rhs)
        {
            int ret = 0;

            byte* src = (byte*)lhs;
            byte* dst = (byte*)rhs.Value;

            while ((ret = *src - *dst) == 0 && *dst != 0)
            {
                ++src;
                ++dst;
            }

            return (-ret < 0 ? 1 : 0) - (ret < 0 ? 1 : 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Compare(utf8string<NSize> lhs,
                                  sbyte*     rhs)
        {
            int ret = 0;

            byte* src = (byte*)lhs.Value;
            byte* dst = (byte*)rhs;

            while ((ret = *src - *dst) == 0 && *dst != 0)
            {
                ++src;
                ++dst;
            }

            return (-ret < 0 ? 1 : 0) - (ret < 0 ? 1 : 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Compare(utf8string<NSize> lhs,
                                  string     rhs)
        {
            int ret = 0;

            byte[] asciiString = Encoding.ASCII.GetBytes(rhs);

            byte* src = (byte*)lhs.Value;
            byte* dst = (byte*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(asciiString).Data);

            while ((ret = *src - *dst) == 0 && *dst != 0)
            {
                ++src;
                ++dst;
            }

            return (-ret < 0 ? 1 : 0) - (ret < 0 ? 1 : 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator sbyte*(utf8string<NSize> value)
        {
            return value.Value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator utf8string(utf8string<NSize> value)
        {
            return new utf8string(value.Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator utf8string<NSize>(string? value)
        {
            return new utf8string<NSize>(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static explicit operator utf8string<NSize>(sbyte* value)
        {
            return new utf8string<NSize>(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return new string(Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(string other)
        {
            if (Length != other.Length)
            {
                return false;
            }

            byte[] asciiString = Encoding.ASCII.GetBytes(other);

            byte* src = (byte*)Value;
            byte* dst = (byte*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(asciiString).Data);

            while (*dst != 0)
            {
                if (*src++ != *dst++)
                {
                    return false;
                }
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(utf8string<NSize> other)
        {
            if (Length != other.Length)
            {
                return false;
            }

            byte* src = (byte*)Value;
            byte* dst = (byte*)other.Value;

            while (*dst != 0)
            {
                if (*src++ != *dst++)
                {
                    return false;
                }
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(sbyte* other)
        {
            if (Length != GetLength(other))
            {
                return false;
            }

            byte* src = (byte*)Value;
            byte* dst = (byte*)other;

            while (*dst != 0)
            {
                if (*src++ != *dst++)
                {
                    return false;
                }
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is utf8string<NSize> other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            sbyte* value = Value;

            HashCode code = new();
            code.Add(*value++);

            while (*value++ != char.MinValue)
            {
                code.Add(*value++);
            }

            return code.ToHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(utf8string<NSize> left,
                                       utf8string<NSize> right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(utf8string<NSize> left,
                                       utf8string<NSize> right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(utf8string<NSize> left,
                                       string     right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(utf8string<NSize> left,
                                       string     right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(string     left,
                                       utf8string<NSize> right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(string     left,
                                       utf8string<NSize> right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(sbyte*     left,
                                       utf8string<NSize> right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(sbyte*     left,
                                       utf8string<NSize> right)
        {
            return !right.Equals(left);
        }
    }
    
}
