using System;
using System.Diagnostics;

namespace 极刺客
{
    class Program
    {
        static void usentsd()
        {
            try
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("StudentMain");//进程名称不要加上.exe
                Process.Start(@".\lib\ntsd.exe", "-y -y -p " + processes[0].Id);
            }
            catch
            {
                Console.WriteLine("该程序已经被杀死");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Trying to kill TopDomain Contrler...");
            极刺客.Program.usentsd();
            Console.WriteLine("按任意键继续。。。code by 相互科技");
            Console.ReadKey();
        }
        
        
    }   
    
}

