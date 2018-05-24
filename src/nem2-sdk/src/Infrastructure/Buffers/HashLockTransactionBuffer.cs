// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using System;
using io.nem2.sdk.Infrastructure.Imported.FlatBuffers;

namespace io.nem2.sdk.Infrastructure.Buffers
{
    internal struct HashLockTransactionBuffer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static HashLockTransactionBuffer GetRootAsTestBuffer(ByteBuffer _bb) { return GetRootAsTestBuffer(_bb, new HashLockTransactionBuffer()); }
  public static HashLockTransactionBuffer GetRootAsTestBuffer(ByteBuffer _bb, HashLockTransactionBuffer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public HashLockTransactionBuffer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Size { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public byte Signature(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int SignatureLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetSignatureBytes() { return __p.__vector_as_arraysegment(6); }
  public byte Signer(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int SignerLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetSignerBytes() { return __p.__vector_as_arraysegment(8); }
  public ushort Version { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public ushort Type { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public uint Fee(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int FeeLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetFeeBytes() { return __p.__vector_as_arraysegment(14); }
  public uint Deadline(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int DeadlineLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDeadlineBytes() { return __p.__vector_as_arraysegment(16); }
  public uint Id(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int IdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(18); }
  public uint Amount(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int AmountLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetAmountBytes() { return __p.__vector_as_arraysegment(20); }
  public uint Duration(int j) { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  public int DurationLength { get { int o = __p.__offset(22); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetDurationBytes() { return __p.__vector_as_arraysegment(22); }
  public byte Hash(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int HashLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetHashBytes() { return __p.__vector_as_arraysegment(24); }

  public static Offset<HashLockTransactionBuffer> CreateTestBuffer(FlatBufferBuilder builder,
      uint size = 0,
      VectorOffset signatureOffset = default(VectorOffset),
      VectorOffset signerOffset = default(VectorOffset),
      ushort version = 0,
      ushort type = 0,
      VectorOffset feeOffset = default(VectorOffset),
      VectorOffset deadlineOffset = default(VectorOffset),
      VectorOffset IdOffset = default(VectorOffset),
      VectorOffset AmountOffset = default(VectorOffset),
      VectorOffset DurationOffset = default(VectorOffset),
      VectorOffset HashOffset = default(VectorOffset)) {
    builder.StartObject(11);
    HashLockTransactionBuffer.AddHash(builder, HashOffset);
    HashLockTransactionBuffer.AddDuration(builder, DurationOffset);
    HashLockTransactionBuffer.AddAmount(builder, AmountOffset);
    HashLockTransactionBuffer.AddId(builder, IdOffset);
    HashLockTransactionBuffer.AddDeadline(builder, deadlineOffset);
    HashLockTransactionBuffer.AddFee(builder, feeOffset);
    HashLockTransactionBuffer.AddSigner(builder, signerOffset);
    HashLockTransactionBuffer.AddSignature(builder, signatureOffset);
    HashLockTransactionBuffer.AddSize(builder, size);
    HashLockTransactionBuffer.AddType(builder, type);
    HashLockTransactionBuffer.AddVersion(builder, version);
    return HashLockTransactionBuffer.EndTestBuffer(builder);
  }

  public static void StartTestBuffer(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddSize(FlatBufferBuilder builder, uint size) { builder.AddUint(0, size, 0); }
  public static void AddSignature(FlatBufferBuilder builder, VectorOffset signatureOffset) { builder.AddOffset(1, signatureOffset.Value, 0); }
  public static VectorOffset CreateSignatureVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartSignatureVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddSigner(FlatBufferBuilder builder, VectorOffset signerOffset) { builder.AddOffset(2, signerOffset.Value, 0); }
  public static VectorOffset CreateSignerVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartSignerVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddVersion(FlatBufferBuilder builder, ushort version) { builder.AddUshort(3, version, 0); }
  public static void AddType(FlatBufferBuilder builder, ushort type) { builder.AddUshort(4, type, 0); }
  public static void AddFee(FlatBufferBuilder builder, VectorOffset feeOffset) { builder.AddOffset(5, feeOffset.Value, 0); }
  public static VectorOffset CreateFeeVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartFeeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDeadline(FlatBufferBuilder builder, VectorOffset deadlineOffset) { builder.AddOffset(6, deadlineOffset.Value, 0); }
  public static VectorOffset CreateDeadlineVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartDeadlineVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddId(FlatBufferBuilder builder, VectorOffset IdOffset) { builder.AddOffset(7, IdOffset.Value, 0); }
  public static VectorOffset CreateIdVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAmount(FlatBufferBuilder builder, VectorOffset AmountOffset) { builder.AddOffset(8, AmountOffset.Value, 0); }
  public static VectorOffset CreateAmountVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDuration(FlatBufferBuilder builder, VectorOffset DurationOffset) { builder.AddOffset(9, DurationOffset.Value, 0); }
  public static VectorOffset CreateDurationVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartDurationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHash(FlatBufferBuilder builder, VectorOffset HashOffset) { builder.AddOffset(10, HashOffset.Value, 0); }
  public static VectorOffset CreateHashVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartHashVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static Offset<HashLockTransactionBuffer> EndTestBuffer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<HashLockTransactionBuffer>(o);
  }
  public static void FinishTestBufferBuffer(FlatBufferBuilder builder, Offset<HashLockTransactionBuffer> offset) { builder.Finish(offset.Value); }
};


}
