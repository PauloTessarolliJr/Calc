using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace YAMP
{
	class SaveFunction : ArgumentFunction
	{
		public Value Function(StringValue filename)
		{
			Save(filename.Value, Tokens.Instance.Variables);
			return new StringValue(Tokens.Instance.Variables.Count + " objects saved.");
		}

		public static void Save(string filename, IDictionary<string, Value> workspace)
		{
			using(var fs = File.Create (filename))
			{
				foreach(string variable in workspace.Keys)
				{
					var idx = Encoding.Unicode.GetBytes(variable);
					var len = BitConverter.GetBytes (idx.Length);
					fs.Write(len, 0, len.Length);
					fs.Write(idx, 0, idx.Length);
					var value = workspace[variable];
					idx = Encoding.ASCII.GetBytes(value.Header);
					len = BitConverter.GetBytes(idx.Length);
					fs.Write(len, 0, len.Length);
					fs.Write(idx, 0, idx.Length);
					idx = value.Serialize();
					len = BitConverter.GetBytes(idx.Length);
					fs.Write(len, 0, len.Length);
					fs.Write(idx, 0, idx.Length);
				}
			}
		}
	}
}

