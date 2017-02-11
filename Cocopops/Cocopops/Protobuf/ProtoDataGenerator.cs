
using System;
using Cocopops.Protobuf.Model.BaseTransaction;
using Cocopops.Protobuf.Model.ExtendedTransaction;
using Cocopops.Protobuf.Model.Transaction;
using Cocopops.Protobuf.Model.TransactionCollection;

namespace Cocopops.Protobuf
{
    class ProtoDataGenerator
    {
        private string GenerateString()
        {
            return Guid.NewGuid().ToString();
        }

        private Transaction GenerateTransaction(bool extended = false)
        {
            var baseTransaction = new BaseTransaction
            {
                ExecutingEntityCode = GenerateString(),
                TransactionReferenceNumber = GenerateString()
            };

            if (!extended)
                return new Transaction {BaseTransaction = baseTransaction};

            var extendedTransaction = new ExtendedTransaction
            {
                BaseTransaction = baseTransaction,
                Comments = GenerateString(),
                Extra = GenerateString()
            };

            return new Transaction {ExtendedTransaction = extendedTransaction};
        }

        public TransactionCollection GetTransactions(int transactions)
        {
            var collection = new TransactionCollection();
            for (int i = 0; i <= transactions; i++)
            {
                collection.Transactions.Add(GenerateTransaction(i % 2 == 0));
            }

            return collection;
        } 
    }
}
