// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Transaction.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cocopops.Protobuf.Model.Transaction {

  /// <summary>Holder for reflection information generated from Transaction.proto</summary>
  public static partial class TransactionReflection {

    #region Descriptor
    /// <summary>File descriptor for Transaction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TransactionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFUcmFuc2FjdGlvbi5wcm90bxIXQ29jb3BvcHMuUHJvdG9idWYuTW9kZWwa",
            "FUJhc2VUcmFuc2FjdGlvbi5wcm90bxoZRXh0ZW5kZWRUcmFuc2FjdGlvbi5w",
            "cm90byKwAQoLVHJhbnNhY3Rpb24SRAoQYmFzZV90cmFuc2FjdGlvbhgBIAEo",
            "CzIoLkNvY29wb3BzLlByb3RvYnVmLk1vZGVsLkJhc2VUcmFuc2FjdGlvbkgA",
            "EkwKFGV4dGVuZGVkX3RyYW5zYWN0aW9uGAIgASgLMiwuQ29jb3BvcHMuUHJv",
            "dG9idWYuTW9kZWwuRXh0ZW5kZWRUcmFuc2FjdGlvbkgAQg0KC3RyYW5zYWN0",
            "aW9uQiaqAiNDb2NvcG9wcy5Qcm90b2J1Zi5Nb2RlbC5UcmFuc2FjdGlvbmIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransactionReflection.Descriptor, global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransactionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cocopops.Protobuf.Model.Transaction.Transaction), global::Cocopops.Protobuf.Model.Transaction.Transaction.Parser, new[]{ "BaseTransaction", "ExtendedTransaction" }, new[]{ "Transaction" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Transaction : pb::IMessage<Transaction> {
    private static readonly pb::MessageParser<Transaction> _parser = new pb::MessageParser<Transaction>(() => new Transaction());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Transaction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cocopops.Protobuf.Model.Transaction.TransactionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transaction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transaction(Transaction other) : this() {
      switch (other.TransactionCase) {
        case TransactionOneofCase.BaseTransaction:
          BaseTransaction = other.BaseTransaction.Clone();
          break;
        case TransactionOneofCase.ExtendedTransaction:
          ExtendedTransaction = other.ExtendedTransaction.Clone();
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Transaction Clone() {
      return new Transaction(this);
    }

    /// <summary>Field number for the "base_transaction" field.</summary>
    public const int BaseTransactionFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction BaseTransaction {
      get { return transactionCase_ == TransactionOneofCase.BaseTransaction ? (global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction) transaction_ : null; }
      set {
        transaction_ = value;
        transactionCase_ = value == null ? TransactionOneofCase.None : TransactionOneofCase.BaseTransaction;
      }
    }

    /// <summary>Field number for the "extended_transaction" field.</summary>
    public const int ExtendedTransactionFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransaction ExtendedTransaction {
      get { return transactionCase_ == TransactionOneofCase.ExtendedTransaction ? (global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransaction) transaction_ : null; }
      set {
        transaction_ = value;
        transactionCase_ = value == null ? TransactionOneofCase.None : TransactionOneofCase.ExtendedTransaction;
      }
    }

    private object transaction_;
    /// <summary>Enum of possible cases for the "transaction" oneof.</summary>
    public enum TransactionOneofCase {
      None = 0,
      BaseTransaction = 1,
      ExtendedTransaction = 2,
    }
    private TransactionOneofCase transactionCase_ = TransactionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TransactionOneofCase TransactionCase {
      get { return transactionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTransaction() {
      transactionCase_ = TransactionOneofCase.None;
      transaction_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Transaction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Transaction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BaseTransaction, other.BaseTransaction)) return false;
      if (!object.Equals(ExtendedTransaction, other.ExtendedTransaction)) return false;
      if (TransactionCase != other.TransactionCase) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (transactionCase_ == TransactionOneofCase.BaseTransaction) hash ^= BaseTransaction.GetHashCode();
      if (transactionCase_ == TransactionOneofCase.ExtendedTransaction) hash ^= ExtendedTransaction.GetHashCode();
      hash ^= (int) transactionCase_;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (transactionCase_ == TransactionOneofCase.BaseTransaction) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseTransaction);
      }
      if (transactionCase_ == TransactionOneofCase.ExtendedTransaction) {
        output.WriteRawTag(18);
        output.WriteMessage(ExtendedTransaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (transactionCase_ == TransactionOneofCase.BaseTransaction) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BaseTransaction);
      }
      if (transactionCase_ == TransactionOneofCase.ExtendedTransaction) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExtendedTransaction);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Transaction other) {
      if (other == null) {
        return;
      }
      switch (other.TransactionCase) {
        case TransactionOneofCase.BaseTransaction:
          BaseTransaction = other.BaseTransaction;
          break;
        case TransactionOneofCase.ExtendedTransaction:
          ExtendedTransaction = other.ExtendedTransaction;
          break;
      }

    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction subBuilder = new global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction();
            if (transactionCase_ == TransactionOneofCase.BaseTransaction) {
              subBuilder.MergeFrom(BaseTransaction);
            }
            input.ReadMessage(subBuilder);
            BaseTransaction = subBuilder;
            break;
          }
          case 18: {
            global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransaction subBuilder = new global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransaction();
            if (transactionCase_ == TransactionOneofCase.ExtendedTransaction) {
              subBuilder.MergeFrom(ExtendedTransaction);
            }
            input.ReadMessage(subBuilder);
            ExtendedTransaction = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
