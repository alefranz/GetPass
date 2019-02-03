using System;
using System.Text;

namespace GetPass
{
    public class ConsolePasswordReader
    {
        public static string Read(string prompt = "Password: ")
        {
            var password = new StringBuilder();
            
            Console.Write(prompt);
            do
            {
                var key = Console.ReadKey(true).KeyChar;

                if (key == '\b')
                {
                    if (password.Length > 0)
                    {
                        password.Remove(password.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                else if (key == '\r')
                {
                    Console.WriteLine();
                    break;
                }
                else if (!char.IsControl(key))
                {
                    password.Append(key);
                    Console.Write('*');
                }
            } while (true);
            
            return password.ToString();
        }
    }
}
