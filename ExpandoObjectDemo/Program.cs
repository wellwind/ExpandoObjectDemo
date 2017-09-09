using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ExpandoObjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            usingDictionary();
            usingExpandoObject();
        }

        private static void usingExpandoObject()
        {
            dynamic data = new ExpandoObject();
            data.Name = "Welwid";
            data.Age = 30;
            data.Sex = Sex.Male;

            Console.WriteLine("-- ExpandoObject --");
			Console.WriteLine(String.Format("Name={0}", data.Name));
			Console.WriteLine(String.Format("Age={0}", data.Age));
			Console.WriteLine(String.Format("Sex={0}", data.Sex));
        }

        private static void usingDictionary()
        {
            var data = new Dictionary<string, object>();
            data.Add("Name", "Wellwind");
            data.Add("Age", 30);
            data["Sex"] = Sex.Male;

            Console.WriteLine("-- Dictionary --");
            Console.WriteLine(String.Format("Name={0}", data["Name"]));
            Console.WriteLine(String.Format("Age={0}", data["Age"]));
            Console.WriteLine(String.Format("Sex={0}", data["Sex"]));
        }
    }

    enum Sex {
        Male,
        Female
    }
}
