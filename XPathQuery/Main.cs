using System;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XPathQuery
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string query = string.Join(" ",args);
			
			XDocument input = XDocument.Parse(Console.In.ReadToEnd());
			
			var res = input.XPathSelectElements(query);
			
			foreach(var el in res)
				Console.WriteLine(el.ToString());
		}
	}
}
