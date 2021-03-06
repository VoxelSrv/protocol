// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/proxy-client.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from proto/proxy-client.proto</summary>
public static partial class ProxyClientReflection {

  #region Descriptor
  /// <summary>File descriptor for proto/proxy-client.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ProxyClientReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Chhwcm90by9wcm94eS1jbGllbnQucHJvdG8ikgEKC0F1dGhSZXF1ZXN0EhAK",
          "CHVzZXJuYW1lGAEgASgJEhAKCHByb3RvY29sGAIgASgNEg4KBmNsaWVudBgD",
          "IAEoCRIMCgR1dWlkGAQgASgJEg4KBnNlY3JldBgFIAEoCRIQCghzZXJ2ZXJJ",
          "ZBgGIAEoCRIfChdwcm94eV9zdXBwb3J0ZWRfdmVyc2lvbhgHIAEoDSIWCgVS",
          "ZWFkeRINCgVyZWFkeRgBIAEoCCIXCgREYXRhEg8KB21lc3NhZ2UYASABKAwi",
          "IgoPVm94ZWxTcnZNZXNzYWdlEg8KB21lc3NhZ2UYASABKAwiHwoMUHJveHlN",
          "ZXNzYWdlEg8KB21lc3NhZ2UYASABKAxiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AuthRequest), global::AuthRequest.Parser, new[]{ "Username", "Protocol", "Client", "Uuid", "Secret", "ServerId", "ProxySupportedVersion" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Ready), global::Ready.Parser, new[]{ "Ready_" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Data), global::Data.Parser, new[]{ "Message" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::VoxelSrvMessage), global::VoxelSrvMessage.Parser, new[]{ "Message" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ProxyMessage), global::ProxyMessage.Parser, new[]{ "Message" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AuthRequest : pb::IMessage<AuthRequest>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AuthRequest> _parser = new pb::MessageParser<AuthRequest>(() => new AuthRequest());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<AuthRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProxyClientReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthRequest(AuthRequest other) : this() {
    username_ = other.username_;
    protocol_ = other.protocol_;
    client_ = other.client_;
    uuid_ = other.uuid_;
    secret_ = other.secret_;
    serverId_ = other.serverId_;
    proxySupportedVersion_ = other.proxySupportedVersion_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public AuthRequest Clone() {
    return new AuthRequest(this);
  }

  /// <summary>Field number for the "username" field.</summary>
  public const int UsernameFieldNumber = 1;
  private string username_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Username {
    get { return username_; }
    set {
      username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "protocol" field.</summary>
  public const int ProtocolFieldNumber = 2;
  private uint protocol_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint Protocol {
    get { return protocol_; }
    set {
      protocol_ = value;
    }
  }

  /// <summary>Field number for the "client" field.</summary>
  public const int ClientFieldNumber = 3;
  private string client_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Client {
    get { return client_; }
    set {
      client_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "uuid" field.</summary>
  public const int UuidFieldNumber = 4;
  private string uuid_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Uuid {
    get { return uuid_; }
    set {
      uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "secret" field.</summary>
  public const int SecretFieldNumber = 5;
  private string secret_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Secret {
    get { return secret_; }
    set {
      secret_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "serverId" field.</summary>
  public const int ServerIdFieldNumber = 6;
  private string serverId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string ServerId {
    get { return serverId_; }
    set {
      serverId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "proxy_supported_version" field.</summary>
  public const int ProxySupportedVersionFieldNumber = 7;
  private uint proxySupportedVersion_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public uint ProxySupportedVersion {
    get { return proxySupportedVersion_; }
    set {
      proxySupportedVersion_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as AuthRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(AuthRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Username != other.Username) return false;
    if (Protocol != other.Protocol) return false;
    if (Client != other.Client) return false;
    if (Uuid != other.Uuid) return false;
    if (Secret != other.Secret) return false;
    if (ServerId != other.ServerId) return false;
    if (ProxySupportedVersion != other.ProxySupportedVersion) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Username.Length != 0) hash ^= Username.GetHashCode();
    if (Protocol != 0) hash ^= Protocol.GetHashCode();
    if (Client.Length != 0) hash ^= Client.GetHashCode();
    if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
    if (Secret.Length != 0) hash ^= Secret.GetHashCode();
    if (ServerId.Length != 0) hash ^= ServerId.GetHashCode();
    if (ProxySupportedVersion != 0) hash ^= ProxySupportedVersion.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Username.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Username);
    }
    if (Protocol != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Protocol);
    }
    if (Client.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Client);
    }
    if (Uuid.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Uuid);
    }
    if (Secret.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Secret);
    }
    if (ServerId.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(ServerId);
    }
    if (ProxySupportedVersion != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ProxySupportedVersion);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Username.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Username);
    }
    if (Protocol != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Protocol);
    }
    if (Client.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Client);
    }
    if (Uuid.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(Uuid);
    }
    if (Secret.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(Secret);
    }
    if (ServerId.Length != 0) {
      output.WriteRawTag(50);
      output.WriteString(ServerId);
    }
    if (ProxySupportedVersion != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ProxySupportedVersion);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Username.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
    }
    if (Protocol != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Protocol);
    }
    if (Client.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Client);
    }
    if (Uuid.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
    }
    if (Secret.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Secret);
    }
    if (ServerId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerId);
    }
    if (ProxySupportedVersion != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProxySupportedVersion);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(AuthRequest other) {
    if (other == null) {
      return;
    }
    if (other.Username.Length != 0) {
      Username = other.Username;
    }
    if (other.Protocol != 0) {
      Protocol = other.Protocol;
    }
    if (other.Client.Length != 0) {
      Client = other.Client;
    }
    if (other.Uuid.Length != 0) {
      Uuid = other.Uuid;
    }
    if (other.Secret.Length != 0) {
      Secret = other.Secret;
    }
    if (other.ServerId.Length != 0) {
      ServerId = other.ServerId;
    }
    if (other.ProxySupportedVersion != 0) {
      ProxySupportedVersion = other.ProxySupportedVersion;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Username = input.ReadString();
          break;
        }
        case 16: {
          Protocol = input.ReadUInt32();
          break;
        }
        case 26: {
          Client = input.ReadString();
          break;
        }
        case 34: {
          Uuid = input.ReadString();
          break;
        }
        case 42: {
          Secret = input.ReadString();
          break;
        }
        case 50: {
          ServerId = input.ReadString();
          break;
        }
        case 56: {
          ProxySupportedVersion = input.ReadUInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Username = input.ReadString();
          break;
        }
        case 16: {
          Protocol = input.ReadUInt32();
          break;
        }
        case 26: {
          Client = input.ReadString();
          break;
        }
        case 34: {
          Uuid = input.ReadString();
          break;
        }
        case 42: {
          Secret = input.ReadString();
          break;
        }
        case 50: {
          ServerId = input.ReadString();
          break;
        }
        case 56: {
          ProxySupportedVersion = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Ready : pb::IMessage<Ready>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Ready> _parser = new pb::MessageParser<Ready>(() => new Ready());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Ready> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProxyClientReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Ready() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Ready(Ready other) : this() {
    ready_ = other.ready_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Ready Clone() {
    return new Ready(this);
  }

  /// <summary>Field number for the "ready" field.</summary>
  public const int Ready_FieldNumber = 1;
  private bool ready_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Ready_ {
    get { return ready_; }
    set {
      ready_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Ready);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Ready other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Ready_ != other.Ready_) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Ready_ != false) hash ^= Ready_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Ready_ != false) {
      output.WriteRawTag(8);
      output.WriteBool(Ready_);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Ready_ != false) {
      output.WriteRawTag(8);
      output.WriteBool(Ready_);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Ready_ != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Ready other) {
    if (other == null) {
      return;
    }
    if (other.Ready_ != false) {
      Ready_ = other.Ready_;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          Ready_ = input.ReadBool();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          Ready_ = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class Data : pb::IMessage<Data>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Data> _parser = new pb::MessageParser<Data>(() => new Data());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Data> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProxyClientReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Data() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Data(Data other) : this() {
    message_ = other.message_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Data Clone() {
    return new Data(this);
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 1;
  private pb::ByteString message_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Data);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Data other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Message != other.Message) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Message);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Message);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Message);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Data other) {
    if (other == null) {
      return;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Message = input.ReadBytes();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Message = input.ReadBytes();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class VoxelSrvMessage : pb::IMessage<VoxelSrvMessage>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VoxelSrvMessage> _parser = new pb::MessageParser<VoxelSrvMessage>(() => new VoxelSrvMessage());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<VoxelSrvMessage> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProxyClientReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public VoxelSrvMessage() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public VoxelSrvMessage(VoxelSrvMessage other) : this() {
    message_ = other.message_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public VoxelSrvMessage Clone() {
    return new VoxelSrvMessage(this);
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 1;
  private pb::ByteString message_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as VoxelSrvMessage);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(VoxelSrvMessage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Message != other.Message) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Message);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Message);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Message);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(VoxelSrvMessage other) {
    if (other == null) {
      return;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Message = input.ReadBytes();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Message = input.ReadBytes();
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class ProxyMessage : pb::IMessage<ProxyMessage>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ProxyMessage> _parser = new pb::MessageParser<ProxyMessage>(() => new ProxyMessage());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ProxyMessage> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ProxyClientReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ProxyMessage() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ProxyMessage(ProxyMessage other) : this() {
    message_ = other.message_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ProxyMessage Clone() {
    return new ProxyMessage(this);
  }

  /// <summary>Field number for the "message" field.</summary>
  public const int MessageFieldNumber = 1;
  private pb::ByteString message_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Message {
    get { return message_; }
    set {
      message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ProxyMessage);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ProxyMessage other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Message != other.Message) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Message.Length != 0) hash ^= Message.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Message);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Message.Length != 0) {
      output.WriteRawTag(10);
      output.WriteBytes(Message);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Message.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Message);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ProxyMessage other) {
    if (other == null) {
      return;
    }
    if (other.Message.Length != 0) {
      Message = other.Message;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Message = input.ReadBytes();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Message = input.ReadBytes();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
