﻿using Enigma.D3.MemoryModel.Core;
using Enigma.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel64.Core
{
	public class TimedEvent : MemoryObject, ITimedEvent
	{
		public const int SizeOf = Constants.TimedEvent.SizeOf;
	}
}
