using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Benchmarks
{
    //using System;
    //using System.Runtime.CompilerServices;
    //using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct OpaqueHandle : IDisposable
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public OpaqueHandle()
        {
            _handle = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public OpaqueHandle(nint handle)
        {
            _handle = (nuint)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public OpaqueHandle(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nint(in OpaqueHandle value)
        {
            return (nint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in OpaqueHandle value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator OpaqueHandle(nint value)
        {
            return new OpaqueHandle(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator OpaqueHandle(nuint value)
        {
            return new OpaqueHandle(value);
        }

        public void Dispose()
        {
            if(_handle != 0)
            {
            }
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct OpaqueHandles
    {
        //public static readonly int OpaqueHandleSize;

        //static OpaqueHandles()
        //{
        //    OpaqueHandleSize = Unsafe.SizeOf<OpaqueHandle>();
        //}

        public OpaqueHandle_fixed_size_array_20 handles;

        [StructLayout(LayoutKind.Sequential)]
        public struct OpaqueHandle_fixed_size_array_20
        {
            public OpaqueHandle E0;
            public OpaqueHandle E1;
            public OpaqueHandle E2;
            public OpaqueHandle E3;
            public OpaqueHandle E4;
            public OpaqueHandle E5;
            public OpaqueHandle E6;
            public OpaqueHandle E7;
            public OpaqueHandle E8;
            public OpaqueHandle E9;
            public OpaqueHandle E10;
            public OpaqueHandle E11;
            public OpaqueHandle E12;
            public OpaqueHandle E13;
            public OpaqueHandle E14;
            public OpaqueHandle E15;
            public OpaqueHandle E16;
            public OpaqueHandle E17;
            public OpaqueHandle E18;
            public OpaqueHandle E19;

            public unsafe ref OpaqueHandle this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    OpaqueHandle* ptr = (OpaqueHandle*)Unsafe.AsPointer(ref E0);
                    //ptr += (index * OpaqueHandleSize);
                    return ref ptr[index];
                }
            }

            public unsafe ref OpaqueHandle this[long index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    OpaqueHandle* ptr = (OpaqueHandle*)Unsafe.AsPointer(ref E0);
                    //ptr += (index * OpaqueHandleSize);
                    return ref ptr[index];
                }
            }
        }
    }

    
    [StructLayout(LayoutKind.Sequential)]
    public struct FixedHandles
    {
        public OpaqueHandle_fixed_size_array_20 handles;

        [StructLayout(LayoutKind.Sequential)]
        public struct OpaqueHandle_fixed_size_array_20
        {
            public OpaqueHandle E0;
            public OpaqueHandle E1;
            public OpaqueHandle E2;
            public OpaqueHandle E3;
            public OpaqueHandle E4;
            public OpaqueHandle E5;
            public OpaqueHandle E6;
            public OpaqueHandle E7;
            public OpaqueHandle E8;
            public OpaqueHandle E9;
            public OpaqueHandle E10;
            public OpaqueHandle E11;
            public OpaqueHandle E12;
            public OpaqueHandle E13;
            public OpaqueHandle E14;
            public OpaqueHandle E15;
            public OpaqueHandle E16;
            public OpaqueHandle E17;
            public OpaqueHandle E18;
            public OpaqueHandle E19;

            public unsafe ref OpaqueHandle this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (OpaqueHandle* ptr = &this.E0)
                    {
                        OpaqueHandle* pThis = ptr;
                        return ref pThis[index];
                    }
                }
            }

            public unsafe ref OpaqueHandle this[long index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (OpaqueHandle* ptr = &this.E0)
                    {
                        OpaqueHandle* pThis = ptr;
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
