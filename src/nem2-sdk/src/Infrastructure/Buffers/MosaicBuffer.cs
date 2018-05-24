// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

using System;
using io.nem2.sdk.Infrastructure.Imported.FlatBuffers;

namespace io.nem2.sdk.Infrastructure.Buffers
{
    internal struct MosaicBuffer : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  internal static MosaicBuffer GetRootAsMosaicBuffer(ByteBuffer _bb) { return GetRootAsMosaicBuffer(_bb, new MosaicBuffer()); }
  internal static MosaicBuffer GetRootAsMosaicBuffer(ByteBuffer _bb, MosaicBuffer obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  internal MosaicBuffer __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  internal uint Id(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  internal int IdLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  internal ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
  internal uint Amount(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(__p.__vector(o) + j * 4) : (uint)0; }
  internal int AmountLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  internal ArraySegment<byte>? GetAmountBytes() { return __p.__vector_as_arraysegment(6); }

  internal static Offset<MosaicBuffer> CreateMosaicBuffer(FlatBufferBuilder builder,
      VectorOffset idOffset = default(VectorOffset),
      VectorOffset amountOffset = default(VectorOffset)) {
    builder.StartObject(2);
    MosaicBuffer.AddAmount(builder, amountOffset);
    MosaicBuffer.AddId(builder, idOffset);
    return MosaicBuffer.EndMosaicBuffer(builder);
  }

  internal static void StartMosaicBuffer(FlatBufferBuilder builder) { builder.StartObject(2); }
  internal static void AddId(FlatBufferBuilder builder, VectorOffset idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  internal static VectorOffset CreateIdVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  internal static void StartIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  internal static void AddAmount(FlatBufferBuilder builder, VectorOffset amountOffset) { builder.AddOffset(1, amountOffset.Value, 0); }
  internal static VectorOffset CreateAmountVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  internal static void StartAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  internal static Offset<MosaicBuffer> EndMosaicBuffer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<MosaicBuffer>(o);
  }
};


}
