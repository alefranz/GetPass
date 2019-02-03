using System;
using System.Collections.Generic;
using System.Text;

namespace GetPass.Test
{
    public partial class GetPassTest
    {
        public class FakeConsole : IConsole
        {
            private readonly Queue<char> _inputCharacters;
            private readonly StringBuilder _output;

            public FakeConsole(char[] inputCharacters)
            {
                _inputCharacters = new Queue<char>(inputCharacters);
                _inputCharacters.Enqueue('\r');
                _output = new StringBuilder();
            }

            public string Output => _output.ToString();

            public ConsoleKeyInfo ReadKey(bool intercept)
            {
                char c = _inputCharacters.Dequeue();
                // only works for some characters
                return new ConsoleKeyInfo(c, 0, false, false, false);
            }

            public void Write(char value) => _output.Append(value);

            public void Write(string value) => _output.Append(value);

            public void WriteLine() => _output.Append('\n');
        }
    }
}
