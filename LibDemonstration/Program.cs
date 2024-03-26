using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LibDemonstration.SomeClasses;
using Tracer;


namespace LibDemonstration
{
    class Program
    {
        static private Tracer.Tracer _tracer;
        static private Tracer.Tracer _tracer1;
        static private Tracer.Tracer _tracer2;

        static void Main()
        {
            _tracer1 = new Tracer.Tracer(Thread.CurrentThread.ManagedThreadId);

            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();

            Class2 obj2 = new Class2(_tracer1);
            obj2.Method2_1();

            thread1.Join();
            thread2.Join();

            _tracer2.GetTraceResult();
            _tracer.GetTraceResult();
            _tracer1.GetTraceResult();

            _tracer.GetMultiThreadResult("..//..//..//outputJSON.txt", "..//..//..//outputXML.txt");
        }


        static public void Thread1()
        {
            _tracer = new Tracer.Tracer(Thread.CurrentThread.ManagedThreadId);
            Class2 obj2 = new Class2(_tracer);

            obj2.Method2_1();
            obj2.Method2_2();
        }
        static public void Thread2()
        {
            _tracer2 = new Tracer.Tracer(Thread.CurrentThread.ManagedThreadId);
            Class2 obj2 = new Class2(_tracer2);
            Class1 obj1 = new Class1(_tracer2);

            obj2.Method2_1();
            obj1.Method1();
        }

    }
}
