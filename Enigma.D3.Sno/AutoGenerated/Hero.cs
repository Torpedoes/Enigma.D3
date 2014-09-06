using System.Runtime.CompilerServices;
using Enigma.D3.Collections;
using Enigma.D3.Memory;
using Enigma.Memory;

namespace Enigma.D3.Sno
{
	[CompilerGenerated]
	public partial class Hero : SerializeMemoryObject
	{
		// 2.1.0.26451
		public const int SizeOf = 0x20; // 32
		
		public SerializeData x0C_SerializeData { get { return Read<SerializeData>(0x0C); } }
		public byte[] x18_byte { get { return Deserialize<byte>(x0C_SerializeData); } }
	}
}
