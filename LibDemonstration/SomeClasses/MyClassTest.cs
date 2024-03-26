using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracer;

namespace LibDemonstration.SomeClasses
{
    class MyClass
    {
        private ITracer _tracer;

        internal MyClass(ITracer tracer)
        {
            _tracer = tracer;
        }

        public void MethodA()
        {
            _tracer.StartTrace();

            MethodB();
            MethodC();

            _tracer.StopTrace();
        }

        private void MethodB()
        {
            _tracer.StartTrace();

            Thread.Sleep(50);

            _tracer.StopTrace();
        }

        private void MethodC()
        {
            _tracer.StartTrace();

            Thread.Sleep(150);

            MethodD();
            _tracer.StopTrace();
        }

        private void MethodD()
        {
            _tracer.StartTrace();

            Thread.Sleep(100);

            _tracer.StopTrace();
        }
    }
}
