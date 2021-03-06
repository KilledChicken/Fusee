/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 0.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

using System;
using System.Runtime.InteropServices;

public class ParserCache : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ParserCache(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ParserCache obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public bool CopyTo(ParserCache dest) {
    bool ret = C4dApiPINVOKE.ParserCache_CopyTo(swigCPtr, ParserCache.getCPtr(dest));
    return ret;
  }

  public static ParserCache Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.ParserCache_Alloc();
    ParserCache ret = (cPtr == IntPtr.Zero) ? null : new ParserCache(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_ParserCache p) {
    C4dApiPINVOKE.ParserCache_Free(SWIGTYPE_p_p_ParserCache.getCPtr(p));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
