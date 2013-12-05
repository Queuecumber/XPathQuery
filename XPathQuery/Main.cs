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
		    try
		    {
		        var input = XDocument.Parse(Console.In.ReadToEnd());

		        foreach (var query in args)
		        {
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
		    }
		    catch (Exception e)
		    {
		        Console.WriteLine(e.ToString());
		    }
		}
	}
}
