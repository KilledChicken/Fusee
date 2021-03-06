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

public class GvInit : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvInit(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GvInit obj) {
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

  public int cpu_count {
    set {
      C4dApiPINVOKE.GvInit_cpu_count_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvInit_cpu_count_get(swigCPtr);
      return ret;
    } 
  }

  public GvCalcFlags flags {
    set {
      C4dApiPINVOKE.GvInit_flags_set(swigCPtr, (int)value);
    } 
    get {
      GvCalcFlags ret = (GvCalcFlags)C4dApiPINVOKE.GvInit_flags_get(swigCPtr);
      return ret;
    } 
  }

  public void SetError(GvError error) {
    C4dApiPINVOKE.GvInit_SetError(swigCPtr, (int)error);
  }

  public GvError GetError() {
    GvError ret = (GvError)C4dApiPINVOKE.GvInit_GetError(swigCPtr);
    return ret;
  }

}

}
