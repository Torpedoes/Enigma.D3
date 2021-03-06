﻿using Enigma.D3.MemoryModel.Segments;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
	public interface IMemoryContext
	{
		IDataSegment DataSegment { get; }
		IMemory Memory { get; }
	}
}
