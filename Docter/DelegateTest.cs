using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    public delegate string FirstDelegate(int x);
    class DelegateTest
    {
        string name;
        static string StaticMethod(int i)
        {
            return string.Format("Static method: {0}", i);
        }

        string InstanceMethod(int i)
        {
            return string.Format("{0}:{1}", name,i);
        }

        static void Main()
        {
            FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);
            DelegateTest instance = new DelegateTest();
            instance.name = "My Instance";
            FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);
            Console.WriteLine(d1(10));
            Console.WriteLine(d2(5));
            Console.Read();
        }
}}
