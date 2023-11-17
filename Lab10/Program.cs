using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            string[] mystring = str.Split(' ');
            Console.ForegroundColor = ConsoleColor.Green;

            //----------------------------------------------------------
            string[] kol = new string[mystring.Length];
            Console.WriteLine("Веденная строка:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < mystring.Length; i++)
            {
                for (int j = 0; j < mystring[i].Length; j++)
                {
                    char[] s = mystring[i].ToCharArray();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(s[j]);
                    if (s[s.Length-1] == ',' || s[s.Length-1] == '.' || s[s.Length-1] == ':' || s[s.Length-1] == ';' || s[s.Length-1] == '-' || s[s.Length - 1] == '!')
                    {
                        kol[i] = Convert.ToString(s[j]);
                    }
                    else
                    {
                        kol[i] = "1";
                    }
                }
                Console.Write(" ");
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n"); 
            Console.WriteLine("----------------------------------------");
                                    
            //-----------------------------------------------------------------
            Console.WriteLine("Перевернутая строка:");
            string itog = "";

            for (int i = 0; i < mystring.Length; i++)
            {     if (kol[i] != "1")
                {
                    for (int j = mystring[i].Length - 2; j >= 0; j--)
                    {
                        char[] s = mystring[i].ToCharArray();
                        Console.ForegroundColor = ConsoleColor.White;
                        itog = itog + s[j];                        
                    }                    
                    itog = itog + kol[i];
                }
                else
                {
                    for (int j = mystring[i].Length - 1; j >= 0; j--)
                    {
                        char[] s = mystring[i].ToCharArray();
                        Console.ForegroundColor = ConsoleColor.White;
                        itog = itog + s[j];                       
                    }                    
                }
                itog = itog + " ";
            }
            Console.Write(itog);
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------");
        }
    }
}
