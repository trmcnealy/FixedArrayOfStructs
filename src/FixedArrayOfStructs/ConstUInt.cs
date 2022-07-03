using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using System.Text;

namespace System
{
    namespace Const
    {

        [RequiresPreviewFeatures(PreviewFeatureMessage, Url = PreviewFeatureUrl)]
        public interface IUInt
        {
            internal const string PreviewFeatureMessage = "Const.IUInt is in preview.";
            internal const string PreviewFeatureUrl     = "https://github.com/trmcnealy/FixedArrayOfStructs";

            static abstract uint Value { get; }
        }
    
    
        public struct UInt2 : IUInt
        {
            private const uint _value = 2;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt3 : IUInt
        {
            private const uint _value = 3;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt4 : IUInt
        {
            private const uint _value = 4;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt5 : IUInt
        {
            private const uint _value = 5;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt6 : IUInt
        {
            private const uint _value = 6;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt7 : IUInt
        {
            private const uint _value = 7;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt8 : IUInt
        {
            private const uint _value = 8;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt9 : IUInt
        {
            private const uint _value = 9;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt10 : IUInt
        {
            private const uint _value = 10;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt11 : IUInt
        {
            private const uint _value = 11;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt12 : IUInt
        {
            private const uint _value = 12;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt13 : IUInt
        {
            private const uint _value = 13;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt14 : IUInt
        {
            private const uint _value = 14;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt15 : IUInt
        {
            private const uint _value = 15;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt16 : IUInt
        {
            private const uint _value = 16;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt17 : IUInt
        {
            private const uint _value = 17;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt18 : IUInt
        {
            private const uint _value = 18;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt19 : IUInt
        {
            private const uint _value = 19;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt20 : IUInt
        {
            private const uint _value = 20;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt21 : IUInt
        {
            private const uint _value = 21;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt22 : IUInt
        {
            private const uint _value = 22;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt23 : IUInt
        {
            private const uint _value = 23;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt24 : IUInt
        {
            private const uint _value = 24;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt25 : IUInt
        {
            private const uint _value = 25;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt26 : IUInt
        {
            private const uint _value = 26;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt27 : IUInt
        {
            private const uint _value = 27;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt28 : IUInt
        {
            private const uint _value = 28;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt29 : IUInt
        {
            private const uint _value = 29;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt30 : IUInt
        {
            private const uint _value = 30;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt31 : IUInt
        {
            private const uint _value = 31;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt32 : IUInt
        {
            private const uint _value = 32;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt33 : IUInt
        {
            private const uint _value = 33;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt34 : IUInt
        {
            private const uint _value = 34;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt35 : IUInt
        {
            private const uint _value = 35;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt36 : IUInt
        {
            private const uint _value = 36;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt37 : IUInt
        {
            private const uint _value = 37;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt38 : IUInt
        {
            private const uint _value = 38;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt39 : IUInt
        {
            private const uint _value = 39;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt40 : IUInt
        {
            private const uint _value = 40;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt41 : IUInt
        {
            private const uint _value = 41;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt42 : IUInt
        {
            private const uint _value = 42;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt43 : IUInt
        {
            private const uint _value = 43;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt44 : IUInt
        {
            private const uint _value = 44;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt45 : IUInt
        {
            private const uint _value = 45;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt46 : IUInt
        {
            private const uint _value = 46;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt47 : IUInt
        {
            private const uint _value = 47;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt48 : IUInt
        {
            private const uint _value = 48;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt49 : IUInt
        {
            private const uint _value = 49;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt50 : IUInt
        {
            private const uint _value = 50;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt51 : IUInt
        {
            private const uint _value = 51;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt52 : IUInt
        {
            private const uint _value = 52;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt53 : IUInt
        {
            private const uint _value = 53;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt54 : IUInt
        {
            private const uint _value = 54;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt55 : IUInt
        {
            private const uint _value = 55;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt56 : IUInt
        {
            private const uint _value = 56;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt57 : IUInt
        {
            private const uint _value = 57;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt58 : IUInt
        {
            private const uint _value = 58;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt59 : IUInt
        {
            private const uint _value = 59;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt60 : IUInt
        {
            private const uint _value = 60;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt61 : IUInt
        {
            private const uint _value = 61;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt62 : IUInt
        {
            private const uint _value = 62;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt63 : IUInt
        {
            private const uint _value = 63;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt64 : IUInt
        {
            private const uint _value = 64;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt65 : IUInt
        {
            private const uint _value = 65;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt66 : IUInt
        {
            private const uint _value = 66;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt67 : IUInt
        {
            private const uint _value = 67;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt68 : IUInt
        {
            private const uint _value = 68;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt69 : IUInt
        {
            private const uint _value = 69;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt70 : IUInt
        {
            private const uint _value = 70;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt71 : IUInt
        {
            private const uint _value = 71;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt72 : IUInt
        {
            private const uint _value = 72;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt73 : IUInt
        {
            private const uint _value = 73;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt74 : IUInt
        {
            private const uint _value = 74;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt75 : IUInt
        {
            private const uint _value = 75;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt76 : IUInt
        {
            private const uint _value = 76;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt77 : IUInt
        {
            private const uint _value = 77;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt78 : IUInt
        {
            private const uint _value = 78;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt79 : IUInt
        {
            private const uint _value = 79;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt80 : IUInt
        {
            private const uint _value = 80;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt81 : IUInt
        {
            private const uint _value = 81;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt82 : IUInt
        {
            private const uint _value = 82;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt83 : IUInt
        {
            private const uint _value = 83;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt84 : IUInt
        {
            private const uint _value = 84;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt85 : IUInt
        {
            private const uint _value = 85;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt86 : IUInt
        {
            private const uint _value = 86;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt87 : IUInt
        {
            private const uint _value = 87;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt88 : IUInt
        {
            private const uint _value = 88;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt89 : IUInt
        {
            private const uint _value = 89;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt90 : IUInt
        {
            private const uint _value = 90;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt91 : IUInt
        {
            private const uint _value = 91;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt92 : IUInt
        {
            private const uint _value = 92;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt93 : IUInt
        {
            private const uint _value = 93;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt94 : IUInt
        {
            private const uint _value = 94;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt95 : IUInt
        {
            private const uint _value = 95;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt96 : IUInt
        {
            private const uint _value = 96;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt97 : IUInt
        {
            private const uint _value = 97;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt98 : IUInt
        {
            private const uint _value = 98;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt99 : IUInt
        {
            private const uint _value = 99;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt100 : IUInt
        {
            private const uint _value = 100;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt101 : IUInt
        {
            private const uint _value = 101;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt102 : IUInt
        {
            private const uint _value = 102;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt103 : IUInt
        {
            private const uint _value = 103;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt104 : IUInt
        {
            private const uint _value = 104;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt105 : IUInt
        {
            private const uint _value = 105;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt106 : IUInt
        {
            private const uint _value = 106;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt107 : IUInt
        {
            private const uint _value = 107;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt108 : IUInt
        {
            private const uint _value = 108;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt109 : IUInt
        {
            private const uint _value = 109;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt110 : IUInt
        {
            private const uint _value = 110;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt111 : IUInt
        {
            private const uint _value = 111;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt112 : IUInt
        {
            private const uint _value = 112;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt113 : IUInt
        {
            private const uint _value = 113;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt114 : IUInt
        {
            private const uint _value = 114;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt115 : IUInt
        {
            private const uint _value = 115;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt116 : IUInt
        {
            private const uint _value = 116;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt117 : IUInt
        {
            private const uint _value = 117;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt118 : IUInt
        {
            private const uint _value = 118;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt119 : IUInt
        {
            private const uint _value = 119;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt120 : IUInt
        {
            private const uint _value = 120;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt121 : IUInt
        {
            private const uint _value = 121;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt122 : IUInt
        {
            private const uint _value = 122;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt123 : IUInt
        {
            private const uint _value = 123;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt124 : IUInt
        {
            private const uint _value = 124;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt125 : IUInt
        {
            private const uint _value = 125;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt126 : IUInt
        {
            private const uint _value = 126;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt127 : IUInt
        {
            private const uint _value = 127;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt128 : IUInt
        {
            private const uint _value = 128;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt129 : IUInt
        {
            private const uint _value = 129;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt130 : IUInt
        {
            private const uint _value = 130;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt131 : IUInt
        {
            private const uint _value = 131;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt132 : IUInt
        {
            private const uint _value = 132;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt133 : IUInt
        {
            private const uint _value = 133;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt134 : IUInt
        {
            private const uint _value = 134;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt135 : IUInt
        {
            private const uint _value = 135;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt136 : IUInt
        {
            private const uint _value = 136;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt137 : IUInt
        {
            private const uint _value = 137;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt138 : IUInt
        {
            private const uint _value = 138;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt139 : IUInt
        {
            private const uint _value = 139;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt140 : IUInt
        {
            private const uint _value = 140;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt141 : IUInt
        {
            private const uint _value = 141;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt142 : IUInt
        {
            private const uint _value = 142;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt143 : IUInt
        {
            private const uint _value = 143;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt144 : IUInt
        {
            private const uint _value = 144;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt145 : IUInt
        {
            private const uint _value = 145;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt146 : IUInt
        {
            private const uint _value = 146;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt147 : IUInt
        {
            private const uint _value = 147;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt148 : IUInt
        {
            private const uint _value = 148;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt149 : IUInt
        {
            private const uint _value = 149;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt150 : IUInt
        {
            private const uint _value = 150;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt151 : IUInt
        {
            private const uint _value = 151;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt152 : IUInt
        {
            private const uint _value = 152;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt153 : IUInt
        {
            private const uint _value = 153;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt154 : IUInt
        {
            private const uint _value = 154;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt155 : IUInt
        {
            private const uint _value = 155;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt156 : IUInt
        {
            private const uint _value = 156;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt157 : IUInt
        {
            private const uint _value = 157;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt158 : IUInt
        {
            private const uint _value = 158;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt159 : IUInt
        {
            private const uint _value = 159;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt160 : IUInt
        {
            private const uint _value = 160;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt161 : IUInt
        {
            private const uint _value = 161;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt162 : IUInt
        {
            private const uint _value = 162;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt163 : IUInt
        {
            private const uint _value = 163;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt164 : IUInt
        {
            private const uint _value = 164;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt165 : IUInt
        {
            private const uint _value = 165;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt166 : IUInt
        {
            private const uint _value = 166;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt167 : IUInt
        {
            private const uint _value = 167;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt168 : IUInt
        {
            private const uint _value = 168;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt169 : IUInt
        {
            private const uint _value = 169;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt170 : IUInt
        {
            private const uint _value = 170;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt171 : IUInt
        {
            private const uint _value = 171;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt172 : IUInt
        {
            private const uint _value = 172;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt173 : IUInt
        {
            private const uint _value = 173;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt174 : IUInt
        {
            private const uint _value = 174;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt175 : IUInt
        {
            private const uint _value = 175;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt176 : IUInt
        {
            private const uint _value = 176;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt177 : IUInt
        {
            private const uint _value = 177;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt178 : IUInt
        {
            private const uint _value = 178;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt179 : IUInt
        {
            private const uint _value = 179;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt180 : IUInt
        {
            private const uint _value = 180;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt181 : IUInt
        {
            private const uint _value = 181;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt182 : IUInt
        {
            private const uint _value = 182;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt183 : IUInt
        {
            private const uint _value = 183;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt184 : IUInt
        {
            private const uint _value = 184;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt185 : IUInt
        {
            private const uint _value = 185;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt186 : IUInt
        {
            private const uint _value = 186;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt187 : IUInt
        {
            private const uint _value = 187;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt188 : IUInt
        {
            private const uint _value = 188;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt189 : IUInt
        {
            private const uint _value = 189;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt190 : IUInt
        {
            private const uint _value = 190;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt191 : IUInt
        {
            private const uint _value = 191;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt192 : IUInt
        {
            private const uint _value = 192;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt193 : IUInt
        {
            private const uint _value = 193;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt194 : IUInt
        {
            private const uint _value = 194;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt195 : IUInt
        {
            private const uint _value = 195;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt196 : IUInt
        {
            private const uint _value = 196;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt197 : IUInt
        {
            private const uint _value = 197;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt198 : IUInt
        {
            private const uint _value = 198;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt199 : IUInt
        {
            private const uint _value = 199;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt200 : IUInt
        {
            private const uint _value = 200;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt201 : IUInt
        {
            private const uint _value = 201;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt202 : IUInt
        {
            private const uint _value = 202;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt203 : IUInt
        {
            private const uint _value = 203;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt204 : IUInt
        {
            private const uint _value = 204;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt205 : IUInt
        {
            private const uint _value = 205;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt206 : IUInt
        {
            private const uint _value = 206;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt207 : IUInt
        {
            private const uint _value = 207;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt208 : IUInt
        {
            private const uint _value = 208;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt209 : IUInt
        {
            private const uint _value = 209;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt210 : IUInt
        {
            private const uint _value = 210;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt211 : IUInt
        {
            private const uint _value = 211;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt212 : IUInt
        {
            private const uint _value = 212;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt213 : IUInt
        {
            private const uint _value = 213;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt214 : IUInt
        {
            private const uint _value = 214;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt215 : IUInt
        {
            private const uint _value = 215;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt216 : IUInt
        {
            private const uint _value = 216;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt217 : IUInt
        {
            private const uint _value = 217;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt218 : IUInt
        {
            private const uint _value = 218;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt219 : IUInt
        {
            private const uint _value = 219;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt220 : IUInt
        {
            private const uint _value = 220;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt221 : IUInt
        {
            private const uint _value = 221;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt222 : IUInt
        {
            private const uint _value = 222;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt223 : IUInt
        {
            private const uint _value = 223;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt224 : IUInt
        {
            private const uint _value = 224;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt225 : IUInt
        {
            private const uint _value = 225;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt226 : IUInt
        {
            private const uint _value = 226;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt227 : IUInt
        {
            private const uint _value = 227;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt228 : IUInt
        {
            private const uint _value = 228;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt229 : IUInt
        {
            private const uint _value = 229;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt230 : IUInt
        {
            private const uint _value = 230;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt231 : IUInt
        {
            private const uint _value = 231;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt232 : IUInt
        {
            private const uint _value = 232;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt233 : IUInt
        {
            private const uint _value = 233;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt234 : IUInt
        {
            private const uint _value = 234;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt235 : IUInt
        {
            private const uint _value = 235;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt236 : IUInt
        {
            private const uint _value = 236;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt237 : IUInt
        {
            private const uint _value = 237;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt238 : IUInt
        {
            private const uint _value = 238;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt239 : IUInt
        {
            private const uint _value = 239;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt240 : IUInt
        {
            private const uint _value = 240;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt241 : IUInt
        {
            private const uint _value = 241;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt242 : IUInt
        {
            private const uint _value = 242;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt243 : IUInt
        {
            private const uint _value = 243;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt244 : IUInt
        {
            private const uint _value = 244;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt245 : IUInt
        {
            private const uint _value = 245;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt246 : IUInt
        {
            private const uint _value = 246;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt247 : IUInt
        {
            private const uint _value = 247;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt248 : IUInt
        {
            private const uint _value = 248;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt249 : IUInt
        {
            private const uint _value = 249;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt250 : IUInt
        {
            private const uint _value = 250;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt251 : IUInt
        {
            private const uint _value = 251;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt252 : IUInt
        {
            private const uint _value = 252;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt253 : IUInt
        {
            private const uint _value = 253;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt254 : IUInt
        {
            private const uint _value = 254;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt255 : IUInt
        {
            private const uint _value = 255;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

        public struct UInt256 : IUInt
        {
            private const uint _value = 256;

            public static uint Value
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    return _value;
                }
            }
        }

    }
}
