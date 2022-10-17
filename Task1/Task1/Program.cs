using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            FailProcess();
        }
        catch
        {
        }

        Console.WriteLine("Failed to fail process!");
        Console.ReadKey();
    }

    static void FailProcess()
    {
        //1
        Environment.Exit(-1);

        //2
        //Process.GetCurrentProcess().Kill();
        
        //3
        //Environment.FailFast("Fail!");
        
    }
    
}