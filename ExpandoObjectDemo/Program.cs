using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("-- ExpandoObject --");

            dynamic data = new ExpandoObject();

            (data as INotifyPropertyChanged).PropertyChanged += (sender, e) =>
            {
                Console.WriteLine(String.Format("Property {0} has changed.", e.PropertyName));
            };

            data.Name = "Welwid";
            data.Age = 30;
			// 轉型為IDictionary<string, object>進行操作
			(data as IDictionary<string, object>)["Sex"] = Sex.Male;

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
