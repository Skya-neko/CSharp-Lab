using System;
using System.Collections.Generic;

namespace CSharpPart2
{
    public class TryDictionary
    {
        //TryDictionary.Exec();

        public static void Exec()
        {
            // Declare
            Dictionary<string, string> dict = new Dictionary<string, string>();


            // Add
            dict.Add("huga", "shaga");
            dict["hello"] = "Moto";
            //dict.Add("hello", "Momo"); // can't add duplicate key

            // Update value
            dict["hello"] = "World!";

            // Remove
            dict.Remove("huga");


            // Loop through
            foreach (KeyValuePair<string, string> kvp in dict )
            {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }

            // TryGetValue: if index exists->true , and return value
            string value = "";
            if (dict.TryGetValue("hello", out value))
            {
                Console.WriteLine("yes");
                //Console.WriteLine($"key: \"hello\", value: {value}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            
            // ContainsKey very similar to TryGetValue
            // but ContainsKey don't return value
            if (!dict.ContainsKey("qq"))
            {
                Console.WriteLine("NoNo");
            }

            // get values collection 
            foreach (var item in dict.Values)
            {
                Console.WriteLine(item);
            }


            // get keys collection
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item);
            }



        }
    }
}
