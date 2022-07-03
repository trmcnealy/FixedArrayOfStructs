using System.Runtime.CompilerServices;

namespace System;

public struct FixedBuffer2<T>
    where T : unmanaged
{
    public T E0;
    public T E1;

    public unsafe ref T this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            //fixed(T* pThis = &E0)
            {
                T* pThis = (T*)Unsafe.AsPointer(ref E0);

                return ref pThis[index];
            }
        }
    }
}