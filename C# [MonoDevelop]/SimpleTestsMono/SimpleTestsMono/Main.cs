using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


namespace SimpleTestsMono
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Stopwatch stopwatch = new Stopwatch(); 
			const long N = 40000000;
			double[] A, B, C;
			A = new double[N];
			B = new double[N]; 
			C = new double[N];


//			// **** Sequential for loop WITHOUT PARALLEL **** //
//			Console.WriteLine("Starts sequential for now."); 
//			stopwatch.Start();
//			for (int i = 0; i < N; i++)
//			{
//				C[i] = A[i] * B[i]; 
//			}
//			stopwatch.Stop();
//			Console.WriteLine("Sequential loop time in milliseconds: {0}", stopwatch.ElapsedMilliseconds);


//			int numProcs = Environment.ProcessorCount; 
//			Console.WriteLine (numProcs);
//			Console.WriteLine (Environment.OSVersion);
//			Console.WriteLine (Environment.MachineName);
//			Console.WriteLine (Environment.SpecialFolder.Desktop);
//			Console.WriteLine (Environment.UserName);
//			Console.WriteLine (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
//

			// **** Parallel for-loop WITH MYPARALLELFOR **** //
			Console.WriteLine("Starts MyParallelFor now."); 
			stopwatch.Start();
			MyParallelFor(0,N,i =>
			{
				C[i] = A[i] * B[i]; 
			});
			stopwatch.Stop();
			Console.WriteLine("Parallel loop time in milliseconds: {0}", stopwatch.ElapsedMilliseconds);



//			// **** Parallel for-loop WITH PARALLEL.FOR **** //
//			Console.WriteLine("Starts Parallel.For now."); 
//			stopwatch.Start();
//			Parallel.For(0,N, i =>
//			{
//				C[i] = A[i] * B[i]; 
//			});

			stopwatch.Reset();

			Console.WriteLine("Finished"); 
		}


		public static void MyParallelFor(
				int inclusiveLowerBound,long exclusiveUpperBound, Action<int> body)
		{
			long size = exclusiveUpperBound - inclusiveLowerBound;
			int numProcs = Environment.ProcessorCount; 
			long range = size / numProcs;
			// Use a thread for each partition.
			var threads = new List<Thread>(numProcs); 
			for (int p = 0; p < numProcs; p++)
			{
				long start = p * range + inclusiveLowerBound;
				long end = (p == numProcs - 1) ? exclusiveUpperBound : start + range; 
				threads.Add(new Thread(() => {
					for (long i = start; i < end; i++) body((int)i); 
				}));
			}
			foreach (var thread in threads) thread.Start(); 
			foreach (var thread in threads) thread.Join(); // wait on all
		}
//		public static void MyParallelForEach(int source, Action<T> body) 
//		{
//			int numProcs = Environment.ProcessorCount;
//			int remainingWorkItems = numProcs;
//			using (var enumerator = source.GetEnumerator()) {
//				using (ManualResetEvent mre = new ManualResetEvent(false)) {
//					for (int p = 0; p < numProcs; p++) { 
//						ThreadPool.QueueUserWorkItem(delegate 
//						{
//							while (true) { 
//								T nextItem;
//								lock (enumerator) 
//								{
//									if (!enumerator.MoveNext()) break;
//									nextItem = enumerator.Current; 
//								}
//								body(nextItem); 
//							}
//							if (Interlocked.Decrement(ref remainingWorkItems) == 0) 
//								mre.Set();
//						});
//					}
//					mre.WaitOne();
//				}
//			}
//		}
	}

	public class TestClass
	{
		public void TestMethod()
		{
			//Parallel.For(
		}
	}
}
