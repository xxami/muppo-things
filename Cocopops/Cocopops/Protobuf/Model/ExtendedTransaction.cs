// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ExtendedTransaction.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cocopops.Protobuf.Model.ExtendedTransaction {

  /// <summary>Holder for reflection information generated from ExtendedTransaction.proto</summary>
  public static partial class ExtendedTransactionReflection {

    #region Descriptor
    /// <summary>File descriptor for ExtendedTransaction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtendedTransactionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlFeHRlbmRlZFRyYW5zYWN0aW9uLnByb3RvEhdDb2NvcG9wcy5Qcm90b2J1",
            "Zi5Nb2RlbBoVQmFzZVRyYW5zYWN0aW9uLnByb3RvInoKE0V4dGVuZGVkVHJh",
            "bnNhY3Rpb24SQgoQYmFzZV90cmFuc2FjdGlvbhgBIAEoCzIoLkNvY29wb3Bz",
            "LlByb3RvYnVmLk1vZGVsLkJhc2VUcmFuc2FjdGlvbhIQCghjb21tZW50cxgC",
            "IAEoCRINCgVleHRyYRgDIAEoCUIuqgIrQ29jb3BvcHMuUHJvdG9idWYuTW9k",
            "ZWwuRXh0ZW5kZWRUcmFuc2FjdGlvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransactionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransaction), global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransaction.Parser, new[]{ "BaseTransaction", "Comments", "Extra" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExtendedTransaction : pb::IMessage<ExtendedTransaction> {
    private static readonly pb::MessageParser<ExtendedTransaction> _parser = new pb::MessageParser<ExtendedTransaction>(() => new ExtendedTransaction());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExtendedTransaction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cocopops.Protobuf.Model.ExtendedTransaction.ExtendedTransactionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtendedTransaction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtendedTransaction(ExtendedTransaction other) : this() {
      BaseTransaction = other.baseTransaction_ != null ? other.BaseTransaction.Clone() : null;
      comments_ = other.comments_;
      extra_ = other.extra_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExtendedTransaction Clone() {
      return new ExtendedTransaction(this);
    }

    /// <summary>Field number for the "base_transaction" field.</summary>
    public const int BaseTransactionFieldNumber = 1;
    private global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction baseTransaction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction BaseTransaction {
      get { return baseTransaction_; }
      set {
        baseTransaction_ = value;
      }
    }

    /// <summary>Field number for the "comments" field.</summary>
    public const int CommentsFieldNumber = 2;
    private string comments_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Comments {
      get { return comments_; }
      set {
        comments_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extra" field.</summary>
    public const int ExtraFieldNumber = 3;
    private string extra_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Extra {
      get { return extra_; }
      set {
        extra_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExtendedTransaction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExtendedTransaction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BaseTransaction, other.BaseTransaction)) return false;
      if (Comments != other.Comments) return false;
      if (Extra != other.Extra) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (baseTransaction_ != null) hash ^= BaseTransaction.GetHashCode();
      if (Comments.Length != 0) hash ^= Comments.GetHashCode();
      if (Extra.Length != 0) hash ^= Extra.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (baseTransaction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseTransaction);
      }
      if (Comments.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Comments);
      }
      if (Extra.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Extra);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (baseTransaction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BaseTransaction);
      }
      if (Comments.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Comments);
      }
      if (Extra.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Extra);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExtendedTransaction other) {
      if (other == null) {
        return;
      }
      if (other.baseTransaction_ != null) {
        if (baseTransaction_ == null) {
          baseTransaction_ = new global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction();
        }
        BaseTransaction.MergeFrom(other.BaseTransaction);
      }
      if (other.Comments.Length != 0) {
        Comments = other.Comments;
      }
      if (other.Extra.Length != 0) {
        Extra = other.Extra;
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
            if (baseTransaction_ == null) {
              baseTransaction_ = new global::Cocopops.Protobuf.Model.BaseTransaction.BaseTransaction();
            }
            input.ReadMessage(baseTransaction_);
            break;
          }
          case 18: {
            Comments = input.ReadString();
            break;
          }
          case 26: {
            Extra = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code