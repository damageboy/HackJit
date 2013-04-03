﻿using System;
using System.Diagnostics;

namespace HackJit
{
  class Program
  {
    public const int MHZ = 2333333;
    static void Main(string[] args)
    {
      JIT.Init();
      TestBSWAP64();
      TestBSWAP32();
      TestRDTSC();
      TestRDTSCP();
      TestCPUID();
    }

    private unsafe static void TestCPUID()
    {
      uint eax, ebx, ecx, edx;
      eax = 0x00;
      ebx = ecx = edx = 0x00;
    
      JIT.CPUID(ref eax, out ebx, out ecx, out edx);
      var x = stackalloc sbyte[12];
      var p = (uint*) x;
      p[0] = ebx;
      p[1] = edx;
      p[2] = ecx;    

      var cpuid0s = new string(x, 0, 12);

      Console.WriteLine("CPUID: {0}", cpuid0s);
    }

    private static void TestBSWAP32()
    {
      var before = 0x01020304U;
      Console.WriteLine("Before BSWAP32 0x{0:X8}", before);
      var after = JIT.BSWAP32U(before);      
      Console.WriteLine("After  BSWAP32 0x{0:X8}", after);
    }

    private static void TestBSWAP64()
    {
      var before = 0x1122334455667788U;
      Console.WriteLine("Before BSWAP64 0x{0:X8}", before);      
      var after = JIT.BSWAP64U(before);            
      Console.WriteLine("After  BSWAP64 0x{0:X8}", after);
    }

    private static void TestRDTSCP()
    {
      const int LOOP = 1000000;
      var sw = Stopwatch.StartNew();
      var start = JIT.RDTSCP();

      for (var i = 0; i < LOOP; i++)
        JIT.RDTSCP();
      var end = JIT.RDTSCP();
      sw.Stop();    
      Console.WriteLine("SW:     {0}ms",sw.ElapsedMilliseconds);
      Console.WriteLine("RDTSCP: {0}ms", (end - start) / MHZ);
      Console.WriteLine("RDTSCP: {0}cycles", (end - start) / LOOP);   
    }


    private static void TestRDTSC()
    {
      const int LOOP = 1000000;

      var sw = Stopwatch.StartNew();
      var start = JIT.RDTSC();
      for (var i = 0; i < LOOP; i++)
        JIT.RDTSC();
      var end = JIT.RDTSC();
      sw.Stop();    
      Console.WriteLine("SW:    {0}ms", sw.ElapsedMilliseconds);
      Console.WriteLine("RDTSC: {0}ms", (end - start) / MHZ);
      Console.WriteLine("Each RDTSC: {0}cycles", (end - start) / LOOP);
    }
  }
}