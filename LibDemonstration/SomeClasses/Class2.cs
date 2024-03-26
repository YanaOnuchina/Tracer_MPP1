using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracer;

namespace LibDemonstration.SomeClasses
{
    public class Class2
    {
        private readonly Class1 _obj1;
        private readonly ITracer _tracer;

        internal Class2(ITracer tracer)
        {
            _tracer = tracer;
            _obj1 = new Class1(_tracer);
        }

        public void Method2_1()
        {
            _tracer.StartTrace();
            Thread.Sleep(150);
            _obj1.Method1();

            _tracer.StopTrace();
        }

        public void Method2_2()
        {
            _tracer.StartTrace();
            Thread.Sleep(200);
            _obj1.Method1();

            _tracer.StopTrace();
        }
    }
}
