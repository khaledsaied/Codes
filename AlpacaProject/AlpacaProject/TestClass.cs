using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Concurrency.TestTools.UnitTesting;

namespace AlpacaProject
{
    public class TestClass
    {
        public TestClass()
        {
        }

        [UnitTestMethod]
        public void HelloWorldTest()
        {
            Console.WriteLine("Hello world!");
            Console.Error.WriteLine("Oops, this is an error.");

            //Assert.IsTrue(a != null); 
            //Assert.IsNull(a); 
            //Assert.AreEqual(10, n);
        }


        private TaskMeter initMeter = new TaskMeter("Initialize Data");
        private TaskMeter sortingMeter = new TaskMeter("Sort");
        private TaskMeter verificationMeter = new TaskMeter("Verify");

        [UnitTestMethod]
        [PerformanceTestMethod(Repetitions = 5, WarmupRepetitions = 2)]
        [TestArgs(100)]
        [TestArgs(1000)]
        public void SortArray(int n)
        {
            //int n = 1000;
            Random rand = new Random();

            // Create array of random integers
            initMeter.Start();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rand.Next();
            initMeter.End();

            // Sort the array
            sortingMeter.Start();
            SortArray(a);
            sortingMeter.End();

            // Verify Correctness
            verificationMeter.Start();
            try
            {
                for (int i = 1; i < n; i++)
                    Assert.IsTrue(a[i] >= a[i - 1]
                                  , "Element {0} is not sorted correctly", i);
            }
            finally
            {
                verificationMeter.End();
            }
        }

        private void SortArray(int[] a)
        {
            Array.Sort(a);
        }

        [ScheduleTestMethod]
        public void SimpleDeadlock()
        {

            object syncObj1 = new object();
            object syncObj2 = new object();
            Parallel.Invoke(() =>
                {
                    lock (syncObj1)
                        lock (syncObj2)
                        {
                        }
                },
                            () =>
                                {
                                    lock (syncObj1)
                                        lock (syncObj2)
                                        {
                                        }
                                });
        }

    }
}
