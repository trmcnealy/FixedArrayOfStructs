// See https://aka.ms/new-console-template for more information

using System;
using Benchmarks;


const long repeat = 10000000;

int OpaqueHandlesSize = 20;

//nuint[] randValues = new nuint[OpaqueHandlesSize];
bool[][] compare = new bool[repeat][];

for (int r = 0; r < repeat; r++)
{
    compare[r] = new bool[OpaqueHandlesSize];
}

Random rand = new();

//{
//    for(long i = 0; i < randValues.Length; ++i)
//    {
//        randValues[i] = (nuint)rand.Next(0, Int32.MaxValue);
//    }
//}

{
    using(Measure.Execution("OpaqueHandles"))
    {
        OpaqueHandles[] oh = new OpaqueHandles[repeat];

        nuint[] randValues = new nuint[OpaqueHandlesSize];

        for(long r = 0; r < repeat; ++r)
        {
            for (long i = 0; i < randValues.Length; ++i)
            {
                randValues[i] = (nuint)rand.Next(0, Int32.MaxValue);
            }

            for (long i = 0; i < randValues.Length; ++i)
            {
                oh[r].handles[i] = randValues[i];
            }

            for(long i = 0; i < randValues.Length; ++i)
            {
                compare[r][i] |= oh[r].handles[i] == randValues[i];
            }
        }
    }

    for(long r = 0; r < compare.Length; ++r)
    {
        for(long i = 0; i < compare[r].Length; ++i)
        {
            if(!compare[r][i])
            {
                Console.WriteLine($"OpaqueHandles Compare failed i={i}");
            }
            //else
            //{
            //    Console.WriteLine($"OpaqueHandles Compare success i={i}");
            //}
        }
    }
}
{
    using(Measure.Execution("FixedHandles"))
    {
        FixedHandles[] fh = new FixedHandles[repeat];

        nuint[] randValues = new nuint[OpaqueHandlesSize];

        for(long r = 0; r < repeat; ++r)
        {
            for (long i = 0; i < randValues.Length; ++i)
            {
                randValues[i] = (nuint)rand.Next(0, Int32.MaxValue);
            }

            for(long i = 0; i < randValues.Length; ++i)
            {
                fh[r].handles[i] = randValues[i];
            }

            for(long i = 0; i < randValues.Length; ++i)
            {
                compare[r][i] = fh[r].handles[i] == randValues[i];
            }
        }
    }

    for(long r = 0; r < compare.Length; ++r)
    {
        for(long i = 0; i < compare[r].Length; ++i)
        {
            if(!compare[r][i])
            {
                Console.WriteLine($"FixedHandles Compare failed i={i}");
            }
            //else
            //{
            //    Console.WriteLine($"OpaqueHandles Compare success i={i}");
            //}
        }
    }
}


Console.WriteLine("press any key to exit.");
Console.ReadKey();
