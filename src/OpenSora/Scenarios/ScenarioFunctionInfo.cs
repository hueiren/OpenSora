﻿using System.IO;
using System.Text;

namespace OpenSora.Scenarios
{
	public class ScenarioFunctionInfo
	{
		public int Offset { get; }
		public BaseInstruction[] Instructions { get; }

		private ScenarioFunctionInfo(int offset, BaseInstruction[] instructions)
		{
			Offset = offset;
			Instructions = instructions;
		}


		public static ScenarioFunctionInfo FromBinaryReader(BinaryReader reader, int offset)
		{
			reader.BaseStream.Seek(offset, SeekOrigin.Begin);

			var decompiler = new Decompiler(reader);

			var instructions = decompiler.DecompileBlock();

			return new ScenarioFunctionInfo(offset, instructions);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendFormat("void function_{0:X}()\n", Offset);
			sb.Append("{\n");

			foreach(var instruction in Instructions)
			{
				sb.AppendLine(instruction.ToString());
			}

			sb.Append("}\n");

			return sb.ToString();
		}
	}
}
