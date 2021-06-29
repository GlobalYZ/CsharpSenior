using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _018_线程_线程池 {
    class Program {
        /* 使用线程池要注意的事项：
         * 线程池中的所有线程都是后台线程。如果进程的所有前台线程都结束了，所有的后台线程就会停止。不能把入池的线程改为前台线程。
         * 不能给入池的线程设置优先级或名称。入池的线程只能用于时间较短的任务。如果线程要一直运行（如WORD的拼写检查器）线程，
         * 就应使用Thread类创建一个线程。
         */
        static void ThreadMethod(object state)
        {
            Console.WriteLine("线程开始:"+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("线程结束");
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ThreadMethod);//开启一个工作线程
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            Console.ReadKey();

        }
    }
}
