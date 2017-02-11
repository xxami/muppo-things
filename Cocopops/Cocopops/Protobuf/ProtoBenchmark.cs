
using System;
using Cocopops.Protobuf.Model.TransactionCollection;

namespace Cocopops.Protobuf
{
    public class ProtoBenchmark
    {
        private TransactionCollection Transactions { get; set; }

        public ProtoBenchmark()
        {
            var dataGenerator = new ProtoDataGenerator();
            Transactions = dataGenerator.GetTransactions(1000);
        }

        public void Run()
        {
            var serialiser = new ProtoSerialiser();
            serialiser.Serialize();
        }

        public string GetResultMessage()
        {
            throw new NotImplementedException();
        }
    }
}
