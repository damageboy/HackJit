﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DiStorm;

namespace ReJit
{
  [AttributeUsage(AttributeTargets.Method)]
  internal class ReJitAttribute : Attribute
  {
    internal ReJitAttribute(string replacement)
    {
      Replacement = replacement;
    }
    internal string Replacement { get; private set; }
  }

  public static class Intrinsincs
  {
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bswap32")]
    public static int BSWAP32S(int bige)
    {
      BSWAP32S(bige);
      BSWAP32S(bige);
      BSWAP32S(bige);
      BSWAP32S(bige);
      BSWAP32S(bige);
      BSWAP32S(bige);
      return BSWAP32S(bige);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bswap32")]
    public static uint BSWAP32U(uint bige)
    {
      BSWAP32U(bige);
      BSWAP32U(bige);
      BSWAP32U(bige);
      BSWAP32U(bige);
      BSWAP32U(bige);
      BSWAP32U(bige);
      return BSWAP32U(bige);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bswap64")]
    public static long BSWAP64S(long bige, byte dummy = 0x66)
    {
      BSWAP64S(bige);
      BSWAP64S(bige);
      BSWAP64S(bige);
      BSWAP64S(bige);
      BSWAP64S(bige);
      BSWAP64S(bige);
      return BSWAP64S(bige);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bswap64")]
    public static ulong BSWAP64U(ulong bige, byte dummy = 0x66)
    {
      BSWAP64U(bige);
      BSWAP64U(bige);
      BSWAP64U(bige);
      BSWAP64U(bige);
      BSWAP64U(bige);
      BSWAP64U(bige);
      return BSWAP64U(bige);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsf16")]
    public static int BSF(short test)
    {
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      return BSF(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsf16")]
    public static int BSF(ushort test)
    {
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      return BSF(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsr16")]
    public static int BSR(short test)
    {
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      return BSR(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsr16")]
    public static int BSR(ushort test)
    {
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      return BSR(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsf32")]
    public static int BSF(int test)
    {
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      return BSF(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsf32")]
    public static int BSF(uint test)
    {
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      return BSF(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsr32")]
    public static int BSR(int test)
    {
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      return BSR(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsr32")]
    public static int BSR(uint test)
    {
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      return BSR(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsf64")]
    public static int BSF(long test)
    {
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      return BSF(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsf64")]
    public static uint BSF(ulong test)
    {
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      BSF(test);
      return BSF(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsr64")]
    public static int BSR(long test)
    {
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      return BSR(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("bsr64")]
    public static uint BSR(ulong test)
    {
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      BSR(test);
      return BSR(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("popcnt16")]
    public static int POPCNT(short test)
    {
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      return POPCNT(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("popcnt16")]
    public static int POPCNT(ushort test)
    {
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      return POPCNT(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("popcnt32")]
    public static int POPCNT(int test)
    {
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      return POPCNT(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("popcnt32")]
    public static int POPCNT(uint test)
    {
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      return POPCNT(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("popcnt64")]
    public static int POPCNT(long test)
    {
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      return POPCNT(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("popcnt64")]
    public static int POPCNT(ulong test)
    {
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      POPCNT(test);
      return POPCNT(test);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("rdtscp")]
    public static ulong RDTSCP(int dummy = 666)
    {
      RDTSCP(dummy);
      RDTSCP(dummy);
      RDTSCP(dummy);
      RDTSCP(dummy);
      RDTSCP(dummy);
      RDTSCP(dummy);
      return RDTSCP(dummy);
    }
    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("cpuid")]
    public static void CPUID(ref uint eax, out uint ebx, out uint ecx, out uint edx, uint dummy1 = 66, ushort dummy2 = 77, byte dummy3 = 88)
    {
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
      CPUID(ref eax, out ebx, out ecx, out edx);
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    //[HackJit("cpuid")]
    public static void CPUIDNG(ref uint eax, out uint ebx, out uint ecx, out uint edx, uint dummy1 = 66, ushort dummy2 = 77, byte dummy3 = 88)
    {
      eax = ebx = ecx = edx = 0;

      var defaults =
          typeof(Intrinsincs).GetMethod("CPUIDNG")
              .GetParameters()
              .Where(prm => prm.IsOptional)
              .Select(prm => new { prm.ParameterType, prm.RawDefaultValue }).ToArray();

      Console.WriteLine("looking for {0}", String.Join(", ", defaults.Select(x => x.RawDefaultValue)));

      var sf = new StackFrame(1);
      var m = sf.GetMethod();
      var mh = m.MethodHandle;
      var p = mh.GetFunctionPointer();
      var offset = sf.GetNativeOffset();
      var copy = new byte[offset];
      Marshal.Copy(p, copy, 0, offset);

      var ci = new CodeInfo((long)p, copy, DecodeType.Decode64Bits, 0);

      var dc = new DecomposedResult(100);

      DiStorm3.Decompose(ci, dc);

      FindParam(dc, Register.R_RCX);
      FindParam(dc, Register.R_RDX);
      FindParam(dc, Register.R_R8);
      FindParam(dc, Register.R_R9);

      Console.WriteLine(offset);
    }

    private static void FindParam(DecomposedResult dc, int pn)
    {
      Register r;
      switch (pn)
      {
        case 0:
          r = Register.R_RCX;
          break;
        case 1:
          r = Register.R_RDX;
          break;
        case 2:
          r = Register.R_R8;
          break;
        case 3:
          r = Register.R_R9;
          break;
      }
    }

    private static void ParamToRegister(int pn)
    {
    }

    private static void FindParam(DecomposedResult dc, Register reg)
    {
      foreach (var x in dc.Instructions.Reverse())
      {
        if (x.Opcode != Opcode.LEA && x.Opcode != Opcode.MOV)
          continue;
        var op = x.Operands[0];
        if (op.Type != OperandType.Reg || op.Register != reg)
          continue;
        var s = String.Format("{0:X} {1} {2}", x.Address.ToInt64(), x.Opcode, op.Register);
        Console.WriteLine(s);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    [ReJit("rdtsc")]
    public static ulong RDTSC(int dummy1 = 666, byte dummy2 = 66)
    {
      RDTSC();
      RDTSC();
      RDTSC();
      RDTSC();
      RDTSC();
      RDTSC();
      return RDTSC();
    }

    private static byte[] GetOpcodes(string i)
    {
      var assembly = Assembly.GetExecutingAssembly();
      var jitStream = assembly.GetManifestResourceStream("ReJit.Intrinsics." + i + ".o");
      var bytes = new byte[jitStream.Length];
      jitStream.Read(bytes, 0, bytes.Length);
      return bytes;
    }

    public static void Init()
    {
      var candidates = typeof(Intrinsincs).GetMethods(BindingFlags.Static | BindingFlags.Public);

      foreach (var m in candidates) {
        var hja = (ReJitAttribute) m.GetCustomAttributes(typeof(ReJitAttribute), false).SingleOrDefault();
        if (hja == null)
          continue;
        var mh = m.MethodHandle;
        RuntimeHelpers.PrepareMethod(mh);
        var p = mh.GetFunctionPointer();
        var code = GetOpcodes(hja.Replacement);
        if (IntPtr.Size == 8)
          Marshal.Copy(code, 0, p, code.Length);
        else
          throw new NotImplementedException();
      }
    }
  }
}