using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracer;

namespace LibDemonstration.SomeClasses
{
    public class Class1
    {
        private ITracer _tracer;

        internal Class1(ITracer tracer)
        {
            _tracer = tracer;
        }

        public void Method1()
        {
            _tracer.StartTrace();
            Thread.Sleep(100);
            _tracer.StopTrace();
        }
    }
}
