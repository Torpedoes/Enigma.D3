public class dmMeshTriangle : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x1C; // 28

	public dmMeshTriangle(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public short x18 { get { return Field<short>(0x18); } }
	public short x1A { get { return Field<short>(0x1A); } }
}