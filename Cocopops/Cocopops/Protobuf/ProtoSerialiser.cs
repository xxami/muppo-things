
using System;
using System.IO;
using Cocopops.Protobuf.Model;
using Cocopops.Protobuf.Model.BaseTransaction;
using Cocopops.Protobuf.Model.ExtendedTransaction;
using Cocopops.Protobuf.Model.Transaction;
using Cocopops.Protobuf.Model.TransactionCollection;
using Google.Protobuf;

namespace Cocopops.Protobuf
{
    public class ProtoSerialiser
    {
        private TransactionCollection _transactions { get; set; }

        public void Serialize(Stream outStream)
        {
            _transactions.WriteTo(new CodedOutputStream(outStream));
        }

        public TransactionCollection Deserialize(Stream inStream)
        {
            
        }
    }
}
