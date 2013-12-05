using System;
using System.Collections;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XPathQuery
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string query = string.Join(" ",args);

		    try
		    {
		        XDocument input = XDocument.Parse(Console.In.ReadToEnd());

		        try
		        {
		            var res = (IEnumerable) input.XPathEvaluate(query);

		            foreach (var el in res)
		                Console.WriteLine(el.ToString());
		        }
		        catch (Exception e)
		        {
		            Console.WriteLine(e.ToString());
		        }
		    }
		    catch (Exception e)
		    {
		        Console.WriteLine(e.ToString());
		    }
		}
	}
}
