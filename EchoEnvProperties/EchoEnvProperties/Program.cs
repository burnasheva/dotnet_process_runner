using System;
using System.Collections;

namespace EchoEnvProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All Environment Variables:");
            
            foreach(DictionaryEntry e in System.Environment.GetEnvironmentVariables())
            {
                Console.WriteLine(e.Key  + ":" + e.Value);
                
            }
        }
    }
}