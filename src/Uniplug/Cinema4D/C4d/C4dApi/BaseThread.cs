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

public class BaseThread : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BaseThread(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BaseThread obj) {
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

  public bool TestBreak() {
    bool ret = C4dApiPINVOKE.BaseThread_TestBreak(swigCPtr);
    return ret;
  }

  public void End(bool wait) {
    C4dApiPINVOKE.BaseThread_End__SWIG_0(swigCPtr, wait);
  }

  public void End() {
    C4dApiPINVOKE.BaseThread_End__SWIG_1(swigCPtr);
  }

  public bool IsRunning() {
    bool ret = C4dApiPINVOKE.BaseThread_IsRunning(swigCPtr);
    return ret;
  }

}

}
