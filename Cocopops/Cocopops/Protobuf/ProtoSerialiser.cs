
using System.IO;
using Cocopops.Protobuf.Model.TransactionCollection;
using Google.Protobuf;

namespace Cocopops.Protobuf
{
    public class ProtoSerialiser
    {
        public void Serialize(Stream stream, TransactionCollection transactions)
        {
            using (var outStream = new CodedOutputStream(stream))
                transactions.WriteTo(outStream);
        }

        public TransactionCollection Deserialize(Stream stream)
        {
            return TransactionCollection.Parser.ParseFrom(stream);
        }
    }
}
