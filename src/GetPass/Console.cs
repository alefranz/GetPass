using System;

namespace GetPass
{

#if REDIRECT_CONSOLE
    // Replace console call to allow testing
    public interface IConsole
    {
        ConsoleKeyInfo ReadKey(bool intercept);
        void Write(char value);
        void Write(string value);
        void WriteLine();
    }

    internal static class Console
    {
        public static IConsole FakeConsole { get; set; }

        public static ConsoleKeyInfo ReadKey(bool intercept)
        {
            return FakeConsole != null
                ? FakeConsole.ReadKey(intercept)
                : System.Console.ReadKey(intercept);
        }

        public static void Write(char value)
        {
            if (FakeConsole != null)
                FakeConsole.Write(value);
            else
                System.Console.Write(value);
        }

        public static void Write(string value)
        {
            if (FakeConsole != null)
                FakeConsole.Write(value);
            else
                System.Console.Write(value);
        }

        public static void WriteLine()
        {
            if (FakeConsole != null)
                FakeConsole.WriteLine();
            else
                System.Console.WriteLine();
        }
    }
#endif
}
