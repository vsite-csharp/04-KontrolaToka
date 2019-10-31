using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.IO;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public abstract class ConsoleTest
    {
        protected class ConsoleTestWriter : StringWriter
        {
            public override void WriteLine(string? value)
            {
                output.Enqueue(value);
            }

            public override void WriteLine(int value)
            {
                output.Enqueue(value);
            }

            public string GetString()
            {
                return (string)output.Dequeue()!;
            }

            public int GetInt()
            {
                return (int)output.Dequeue()!;
            }

            public bool IsEmpty
            {
                get { return output.Count == 0; }
            }

            readonly Queue output = new Queue();
        }

        protected ConsoleTestWriter? cw = null;

        [TestInitialize()]
        public virtual void Initialize()
        {
            cw = new ConsoleTestWriter();
            Console.SetOut(cw);
        }

        [TestCleanup()]
        public virtual void Cleanup()
        {
            cw?.Dispose();
        }
    }
}
