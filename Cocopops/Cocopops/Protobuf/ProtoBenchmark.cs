
using System;
using System.IO;
using System.Diagnostics;
using Cocopops.Protobuf.Model.TransactionCollection;

namespace Cocopops.Protobuf
{
    public class ProtoBenchmark
    {
        private TransactionCollection Transactions { get; set; }
        private Stopwatch SerialisationWatch { get; set; }
        private Stopwatch DeserialisationWatch { get; set; }
        private int SerialisedBytes { get; set; }

        public ProtoBenchmark(int transactionCount)
        {
            var dataGenerator = new ProtoDataGenerator();
            Transactions = dataGenerator.GetTransactions(transactionCount);
            SerialisationWatch = new Stopwatch();
            DeserialisationWatch = new Stopwatch();
            SerialisedBytes = 0;
        }

        public void Run()
        {
            var serialiser = new ProtoSerialiser();
            using (var outStream = new MemoryStream())
            {

                SerialisationWatch.Start();
                serialiser.Serialize(outStream, Transactions);
                SerialisationWatch.Stop();

                var serialised = outStream.ToArray();
                SerialisedBytes = serialised.Length;

                using (var inStream = new MemoryStream(serialised))
                {
                    DeserialisationWatch.Start();
                    serialiser.Deserialize(inStream);
                    DeserialisationWatch.Stop();
                }
            }
        }

        public string GetResultMessage()
        {
            var result = new string[]
            {
                $" Serialising {Transactions.Transactions.Count} transactions w/ Protobuf...",
                $"    Serialise: {SerialisationWatch.Elapsed.ToString("mm\\:ss\\.ffff")} ({SerialisedBytes} bytes)",
                $"    Deserialise: {DeserialisationWatch.Elapsed.ToString("mm\\:ss\\.ffff")}",
            };

            return String.Join(Environment.NewLine, result);
        }
    }
}
