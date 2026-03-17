using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 100000;

        var list = new List<int>();
        var linkedList = new LinkedList<int>();

        Stopwatch sw = new Stopwatch();

        sw.Start();
        for (int i = 0; i < n; i++)
            list.Add(i);
        sw.Stop();
        Console.WriteLine("List Add: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        for (int i = 0; i < n; i++)
            linkedList.AddLast(i);
        sw.Stop();
        Console.WriteLine("LinkedList Add: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        list.Contains(n - 1);
        sw.Stop();
        Console.WriteLine("List Search: " + sw.ElapsedTicks);

        sw.Restart();
        linkedList.Contains(n - 1);
        sw.Stop();
        Console.WriteLine("LinkedList Search: " + sw.ElapsedTicks);

        sw.Restart();
        list.Remove(n - 1);
        sw.Stop();
        Console.WriteLine("List Remove: " + sw.ElapsedTicks);

        sw.Restart();
        linkedList.Remove(n - 1);
        sw.Stop();
        Console.WriteLine("LinkedList Remove: " + sw.ElapsedTicks);
    }
}