﻿using System;
using System.Runtime.InteropServices;

namespace HookJitCompile
{
  public enum CorJitResult : uint
  {
    // Note that I dont use FACILITY_NULL for the facility number,
    // we may want to get a 'real' facility number
    CORJIT_OK = 0,

    CORJIT_BADCODE = 0x80000001U,
    CORJIT_OUTOFMEM = 0x80000002U,
    CORJIT_INTERNALERROR = 0x80000003U,
    CORJIT_SKIPPED = 0x80000004U,
  };

  public enum CorJitFlag : uint
  {
    CORJIT_FLG_SPEED_OPT = 0x00000001,
    CORJIT_FLG_SIZE_OPT = 0x00000002,
    CORJIT_FLG_DEBUG_CODE = 0x00000004, // generate "debuggable" code (no code-mangling optimizations)
    CORJIT_FLG_DEBUG_EnC = 0x00000008, // We are in Edit-n-Continue mode
    CORJIT_FLG_DEBUG_INFO = 0x00000010, // generate line and local-var info
    CORJIT_FLG_LOOSE_EXCEPT_ORDER = 0x00000020, // loose exception order
    CORJIT_FLG_TARGET_PENTIUM = 0x00000100,
    CORJIT_FLG_TARGET_PPRO = 0x00000200,
    CORJIT_FLG_TARGET_P4 = 0x00000400,
    CORJIT_FLG_TARGET_BANIAS = 0x00000800,
    CORJIT_FLG_USE_FCOMI = 0x00001000, // Generated code may use fcomi(p) instruction
    CORJIT_FLG_USE_CMOV = 0x00002000, // Generated code may use cmov instruction
    CORJIT_FLG_USE_SSE2 = 0x00004000, // Generated code may use SSE-2 instructions
    CORJIT_FLG_PROF_CALLRET = 0x00010000, // Wrap method calls with probes
    CORJIT_FLG_PROF_ENTERLEAVE = 0x00020000, // Instrument prologues/epilogues
    CORJIT_FLG_PROF_INPROC_ACTIVE_DEPRECATED = 0x00040000,

    // Inprocess debugging active requires different instrumentation
    CORJIT_FLG_PROF_NO_PINVOKE_INLINE = 0x00080000, // Disables PInvoke inlining

    CORJIT_FLG_SKIP_VERIFICATION = 0x00100000,

    // (lazy) skip verification - determined without doing a full resolve. See comment below
    CORJIT_FLG_PREJIT = 0x00200000, // jit or prejit is the execution engine.

    CORJIT_FLG_RELOC = 0x00400000, // Generate relocatable code
    CORJIT_FLG_IMPORT_ONLY = 0x00800000, // Only import the function
    CORJIT_FLG_IL_STUB = 0x01000000, // method is an IL stub
    CORJIT_FLG_PROCSPLIT = 0x02000000, // JIT should separate code into hot and cold sections
    CORJIT_FLG_BBINSTR = 0x04000000, // Collect basic block profile information
    CORJIT_FLG_BBOPT = 0x08000000, // Optimize method based on profile information
    CORJIT_FLG_FRAMED = 0x10000000, // All methods have an EBP frame
    CORJIT_FLG_ALIGN_LOOPS = 0x20000000, // add NOPs before loops to align them at 16 byte boundaries
    CORJIT_FLG_PUBLISH_SECRET_PARAM = 0x40000000, // JIT must place stub secret param into local 0.  (used by IL stubs)
  };

  [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 0x88)]
  public unsafe struct CorMethodInfo {
    public byte *methodHandle;
    public byte *moduleHandle;
    public byte *ilCode;
    public uint ilCodeSize;
    public ushort maxStack;
    public ushort EHCount;
    public uint corInfoOptions;
  }
}