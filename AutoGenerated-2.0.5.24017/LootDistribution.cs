public class LootDistribution : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x5C; // 92

	public LootDistribution(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00 { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
	public int x08 { get { return Field<int>(0x08); } }
	public int x0C { get { return Field<int>(0x0C); } }
	public int x10 { get { return Field<int>(0x10); } }
	public int x14 { get { return Field<int>(0x14); } }
	public int x18 { get { return Field<int>(0x18); } }
	public int x1C { get { return Field<int>(0x1C); } }
	public int x20 { get { return Field<int>(0x20); } }
	public int x24 { get { return Field<int>(0x24); } }
	public float x28 { get { return Field<float>(0x28); } }
	public float x2C { get { return Field<float>(0x2C); } }
	public float x30 { get { return Field<float>(0x30); } }
	public float x34 { get { return Field<float>(0x34); } }
	public float x38 { get { return Field<float>(0x38); } }
	public float x3C { get { return Field<float>(0x3C); } }
	public float x40 { get { return Field<float>(0x40); } }
	public float x44 { get { return Field<float>(0x44); } }
	public float x48 { get { return Field<float>(0x48); } }
	public float x4C { get { return Field<float>(0x4C); } }
	public float x50 { get { return Field<float>(0x50); } }
	public int x54 { get { return Field<int>(0x54); } }
	public int x58 { get { return Field<int>(0x58); } }
}