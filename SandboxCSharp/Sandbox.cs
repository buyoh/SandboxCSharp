using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxCSharp
{
    class Solver
    {

        void Solve()
        {
            int n = io.ScanInt();

            long z = 0;
            for (int i = 0; i < n; ++i)
            {
                z += io.ScanLong();
            }
            io.Write(z);
        }


        // =================================================
        // =================================================

        Stdio io;
        static void Main()
        {
            new Solver();
        }
        Solver(Stdio _io = null)
        {
            io = _io == null ? new Stdio() : io;
            Solve();
        }
    }
    class Stdio
    {
        protected string[] stack = new string[0];
        protected int stackptr = 0;

        public virtual int ScanInt()
        {
            return Check() ? int.Parse(stack[stackptr++]) : 0;
        }
        public virtual long ScanLong()
        {
            return Check() ? long.Parse(stack[stackptr++]) : 0;
        }
        public virtual string ScanString()
        {
            return Check() ? stack[stackptr++] : string.Empty;
        }
        public virtual double ScanDouble()
        {
            return Check() ? double.Parse(stack[stackptr++]) : 0;
        }
        protected virtual bool Check()
        {
            if (stackptr < stack.Length) return true;
            var l = Console.ReadLine();
            if (l == null) return false;
            stack = l.Split(' ').ToArray(); stackptr = 0;
            return Check();
        }
        public Stdio Write(long v)
        {
            Console.Write($"{v}");
            return this;
        }
        public Stdio WriteLn(long v)
        {
            Console.WriteLine($"{v}");
            return this;
        }
        public Stdio Write(string str)
        {
            Console.Write(str);
            return this;
        }
        public Stdio WriteLn(string str = "")
        {
            Console.WriteLine(str);
            return this;
        }
    }
}
