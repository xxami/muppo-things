// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BaseTransaction.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cocopops.Model.BaseTransaction {

  /// <summary>Holder for reflection information generated from BaseTransaction.proto</summary>
  public static partial class BaseTransactionReflection {

    #region Descriptor
    /// <summary>File descriptor for BaseTransaction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BaseTransactionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVCYXNlVHJhbnNhY3Rpb24ucHJvdG8SDkNvY29wb3BzLk1vZGVsIlYKD0Jh",
            "c2VUcmFuc2FjdGlvbhIkChx0cmFuc2FjdGlvbl9yZWZlcmVuY2VfbnVtYmVy",
            "GAEgASgJEh0KFWV4ZWN1dGluZ19lbnRpdHlfY29kZRgCIAEoCUIhqgIeQ29j",
            "b3BvcHMuTW9kZWwuQmFzZVRyYW5zYWN0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cocopops.Model.BaseTransaction.BaseTransaction), global::Cocopops.Model.BaseTransaction.BaseTransaction.Parser, new[]{ "TransactionReferenceNumber", "ExecutingEntityCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BaseTransaction : pb::IMessage<BaseTransaction> {
    private static readonly pb::MessageParser<BaseTransaction> _parser = new pb::MessageParser<BaseTransaction>(() => new BaseTransaction());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BaseTransaction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cocopops.Model.BaseTransaction.BaseTransactionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BaseTransaction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BaseTransaction(BaseTransaction other) : this() {
      transactionReferenceNumber_ = other.transactionReferenceNumber_;
      executingEntityCode_ = other.executingEntityCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BaseTransaction Clone() {
      return new BaseTransaction(this);
    }

    /// <summary>Field number for the "transaction_reference_number" field.</summary>
    public const int TransactionReferenceNumberFieldNumber = 1;
    private string transactionReferenceNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TransactionReferenceNumber {
      get { return transactionReferenceNumber_; }
      set {
        transactionReferenceNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "executing_entity_code" field.</summary>
    public const int ExecutingEntityCodeFieldNumber = 2;
    private string executingEntityCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExecutingEntityCode {
      get { return executingEntityCode_; }
      set {
        executingEntityCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BaseTransaction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BaseTransaction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TransactionReferenceNumber != other.TransactionReferenceNumber) return false;
      if (ExecutingEntityCode != other.ExecutingEntityCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TransactionReferenceNumber.Length != 0) hash ^= TransactionReferenceNumber.GetHashCode();
      if (ExecutingEntityCode.Length != 0) hash ^= ExecutingEntityCode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TransactionReferenceNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TransactionReferenceNumber);
      }
      if (ExecutingEntityCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ExecutingEntityCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TransactionReferenceNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TransactionReferenceNumber);
      }
      if (ExecutingEntityCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExecutingEntityCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BaseTransaction other) {
      if (other == null) {
        return;
      }
      if (other.TransactionReferenceNumber.Length != 0) {
        TransactionReferenceNumber = other.TransactionReferenceNumber;
      }
      if (other.ExecutingEntityCode.Length != 0) {
        ExecutingEntityCode = other.ExecutingEntityCode;
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
            TransactionReferenceNumber = input.ReadString();
            break;
          }
          case 18: {
            ExecutingEntityCode = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code