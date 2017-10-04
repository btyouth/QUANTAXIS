// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: stock_min.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from stock_min.proto</summary>
public static partial class StockMinReflection {

  #region Descriptor
  /// <summary>File descriptor for stock_min.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static StockMinReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg9zdG9ja19taW4ucHJvdG8iuQEKCXN0b2NrX21pbhIMCgRjb2RlGAEgASgJ",
          "EgwKBG9wZW4YAiABKAISDAoEaGlnaBgDIAEoAhILCgNsb3cYBCABKAISDQoF",
          "Y2xvc2UYBSABKAISDgoGdm9sdW1lGAYgASgCEgwKBGRhdGUYByABKAkSDgoG",
          "YW1vdW50GAggASgCEhIKCmRhdGVfc3RhbXAYCSABKAkSEAoIZGF0ZXRpbWUY",
          "CiABKAkSEgoKdGltZV9zdGFtcBgLIAEoCWIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::stock_min), global::stock_min.Parser, new[]{ "Code", "Open", "High", "Low", "Close", "Volume", "Date", "Amount", "DateStamp", "Datetime", "TimeStamp" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class stock_min : pb::IMessage<stock_min> {
  private static readonly pb::MessageParser<stock_min> _parser = new pb::MessageParser<stock_min>(() => new stock_min());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<stock_min> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::StockMinReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public stock_min() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public stock_min(stock_min other) : this() {
    code_ = other.code_;
    open_ = other.open_;
    high_ = other.high_;
    low_ = other.low_;
    close_ = other.close_;
    volume_ = other.volume_;
    date_ = other.date_;
    amount_ = other.amount_;
    dateStamp_ = other.dateStamp_;
    datetime_ = other.datetime_;
    timeStamp_ = other.timeStamp_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public stock_min Clone() {
    return new stock_min(this);
  }

  /// <summary>Field number for the "code" field.</summary>
  public const int CodeFieldNumber = 1;
  private string code_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Code {
    get { return code_; }
    set {
      code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "open" field.</summary>
  public const int OpenFieldNumber = 2;
  private float open_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Open {
    get { return open_; }
    set {
      open_ = value;
    }
  }

  /// <summary>Field number for the "high" field.</summary>
  public const int HighFieldNumber = 3;
  private float high_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float High {
    get { return high_; }
    set {
      high_ = value;
    }
  }

  /// <summary>Field number for the "low" field.</summary>
  public const int LowFieldNumber = 4;
  private float low_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Low {
    get { return low_; }
    set {
      low_ = value;
    }
  }

  /// <summary>Field number for the "close" field.</summary>
  public const int CloseFieldNumber = 5;
  private float close_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Close {
    get { return close_; }
    set {
      close_ = value;
    }
  }

  /// <summary>Field number for the "volume" field.</summary>
  public const int VolumeFieldNumber = 6;
  private float volume_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Volume {
    get { return volume_; }
    set {
      volume_ = value;
    }
  }

  /// <summary>Field number for the "date" field.</summary>
  public const int DateFieldNumber = 7;
  private string date_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Date {
    get { return date_; }
    set {
      date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "amount" field.</summary>
  public const int AmountFieldNumber = 8;
  private float amount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public float Amount {
    get { return amount_; }
    set {
      amount_ = value;
    }
  }

  /// <summary>Field number for the "date_stamp" field.</summary>
  public const int DateStampFieldNumber = 9;
  private string dateStamp_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string DateStamp {
    get { return dateStamp_; }
    set {
      dateStamp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "datetime" field.</summary>
  public const int DatetimeFieldNumber = 10;
  private string datetime_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Datetime {
    get { return datetime_; }
    set {
      datetime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "time_stamp" field.</summary>
  public const int TimeStampFieldNumber = 11;
  private string timeStamp_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string TimeStamp {
    get { return timeStamp_; }
    set {
      timeStamp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as stock_min);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(stock_min other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Code != other.Code) return false;
    if (Open != other.Open) return false;
    if (High != other.High) return false;
    if (Low != other.Low) return false;
    if (Close != other.Close) return false;
    if (Volume != other.Volume) return false;
    if (Date != other.Date) return false;
    if (Amount != other.Amount) return false;
    if (DateStamp != other.DateStamp) return false;
    if (Datetime != other.Datetime) return false;
    if (TimeStamp != other.TimeStamp) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Code.Length != 0) hash ^= Code.GetHashCode();
    if (Open != 0F) hash ^= Open.GetHashCode();
    if (High != 0F) hash ^= High.GetHashCode();
    if (Low != 0F) hash ^= Low.GetHashCode();
    if (Close != 0F) hash ^= Close.GetHashCode();
    if (Volume != 0F) hash ^= Volume.GetHashCode();
    if (Date.Length != 0) hash ^= Date.GetHashCode();
    if (Amount != 0F) hash ^= Amount.GetHashCode();
    if (DateStamp.Length != 0) hash ^= DateStamp.GetHashCode();
    if (Datetime.Length != 0) hash ^= Datetime.GetHashCode();
    if (TimeStamp.Length != 0) hash ^= TimeStamp.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Code.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Code);
    }
    if (Open != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(Open);
    }
    if (High != 0F) {
      output.WriteRawTag(29);
      output.WriteFloat(High);
    }
    if (Low != 0F) {
      output.WriteRawTag(37);
      output.WriteFloat(Low);
    }
    if (Close != 0F) {
      output.WriteRawTag(45);
      output.WriteFloat(Close);
    }
    if (Volume != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(Volume);
    }
    if (Date.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(Date);
    }
    if (Amount != 0F) {
      output.WriteRawTag(69);
      output.WriteFloat(Amount);
    }
    if (DateStamp.Length != 0) {
      output.WriteRawTag(74);
      output.WriteString(DateStamp);
    }
    if (Datetime.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(Datetime);
    }
    if (TimeStamp.Length != 0) {
      output.WriteRawTag(90);
      output.WriteString(TimeStamp);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Code.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
    }
    if (Open != 0F) {
      size += 1 + 4;
    }
    if (High != 0F) {
      size += 1 + 4;
    }
    if (Low != 0F) {
      size += 1 + 4;
    }
    if (Close != 0F) {
      size += 1 + 4;
    }
    if (Volume != 0F) {
      size += 1 + 4;
    }
    if (Date.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
    }
    if (Amount != 0F) {
      size += 1 + 4;
    }
    if (DateStamp.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(DateStamp);
    }
    if (Datetime.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Datetime);
    }
    if (TimeStamp.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(TimeStamp);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(stock_min other) {
    if (other == null) {
      return;
    }
    if (other.Code.Length != 0) {
      Code = other.Code;
    }
    if (other.Open != 0F) {
      Open = other.Open;
    }
    if (other.High != 0F) {
      High = other.High;
    }
    if (other.Low != 0F) {
      Low = other.Low;
    }
    if (other.Close != 0F) {
      Close = other.Close;
    }
    if (other.Volume != 0F) {
      Volume = other.Volume;
    }
    if (other.Date.Length != 0) {
      Date = other.Date;
    }
    if (other.Amount != 0F) {
      Amount = other.Amount;
    }
    if (other.DateStamp.Length != 0) {
      DateStamp = other.DateStamp;
    }
    if (other.Datetime.Length != 0) {
      Datetime = other.Datetime;
    }
    if (other.TimeStamp.Length != 0) {
      TimeStamp = other.TimeStamp;
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
          Code = input.ReadString();
          break;
        }
        case 21: {
          Open = input.ReadFloat();
          break;
        }
        case 29: {
          High = input.ReadFloat();
          break;
        }
        case 37: {
          Low = input.ReadFloat();
          break;
        }
        case 45: {
          Close = input.ReadFloat();
          break;
        }
        case 53: {
          Volume = input.ReadFloat();
          break;
        }
        case 58: {
          Date = input.ReadString();
          break;
        }
        case 69: {
          Amount = input.ReadFloat();
          break;
        }
        case 74: {
          DateStamp = input.ReadString();
          break;
        }
        case 82: {
          Datetime = input.ReadString();
          break;
        }
        case 90: {
          TimeStamp = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code