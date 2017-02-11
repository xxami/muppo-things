
using System;
using Cocopops.Protobuf;

namespace Cocopops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" ░C░o░c░o░p░o░p░s░ {Environment.NewLine}");

            var protoBench = new ProtoBenchmark(3);
            protoBench.Run();
            Console.WriteLine(protoBench.GetResultMessage());

            Console.ReadKey();
        }
    }
}
