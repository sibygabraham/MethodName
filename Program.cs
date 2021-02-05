using System;

namespace MethodName
{
    class Program

    {
        static void Main(string[] args)
        {
            Writeyourname();
        }
        
            public static void Writeyourname()
        {
            Console.Write("please Write your name ");
            try
            {
                string name = Console.ReadLine();

                string text = "hello" + name;
                
                Console.WriteLine ("Hello " + name);

            }
            

            catch

            {
                Console.WriteLine(" Please input valuable data");
            }
          
  
        }
           



    }

    }

