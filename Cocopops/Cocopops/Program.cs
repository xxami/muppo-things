
using System.IO;
using Google.Protobuf;
using Cocopops.Model.BaseTransaction;
using Cocopops.Model.ExtendedTransaction;
using Cocopops.Model.Transaction;
using Cocopops.Model.TransactionCollection;
using System;

namespace Cocopops
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create our first transaction, using the minimal BaseTransaction type
            var firstTransaction = new Transaction
            {
                BaseTransaction =
                    new BaseTransaction {ExecutingEntityCode = "neko1", TransactionReferenceNumber = "donuts0001"}
            };


            // A second transaction, using extra fields provided by ExtendedTransaction type
            var secondTransaction = new Transaction
            {
                ExtendedTransaction = new ExtendedTransaction
                {
                    BaseTransaction =
                        new BaseTransaction {ExecutingEntityCode = "neko2", TransactionReferenceNumber = "cookies0002"},
                    Comments = "cookies are sometimes better than donuts!",
                    Extra = "etc."
                }
            };


            // Two transactions is maaaany transactions
            var allTheTransactions = new TransactionCollection {Transaction = {firstTransaction, secondTransaction}};

            // Serialize all of these things to a file
            using (var outputStream = File.Create("SecretTransactions.dat")) allTheTransactions.WriteTo(outputStream);


            // Deserialize
            TransactionCollection transactionCollection;
            using (var inputStream = File.OpenRead("SecretTransactions.dat"))
                transactionCollection = TransactionCollection.Parser.ParseFrom(inputStream);


            // Does it work?
            foreach (var transaction in transactionCollection.Transaction) {

                // Oneof determination
                switch (transaction.TransactionCase)
                {
                    case Transaction.TransactionOneofCase.BaseTransaction:
                        Console.WriteLine("{0}/{1}", transaction.BaseTransaction.ExecutingEntityCode, transaction.BaseTransaction.TransactionReferenceNumber);
                        break;

                    case Transaction.TransactionOneofCase.ExtendedTransaction:
                        Console.WriteLine("{0}/{1}/{2}/{3}", transaction.ExtendedTransaction.BaseTransaction.ExecutingEntityCode,
                            transaction.ExtendedTransaction.BaseTransaction.TransactionReferenceNumber,
                            transaction.ExtendedTransaction.Comments, transaction.ExtendedTransaction.Extra);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
