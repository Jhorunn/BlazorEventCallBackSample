using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsCallBack.Utils
{
	public static class ExtensionMethods
	{
		public static string ExtendToString(this List<int> list)
		{
			string result = "";
			foreach (int number in list)
			{
				result = $"{result} {number}";
			}
			return result;
		}
	}
}
