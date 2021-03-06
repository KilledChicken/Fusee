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

public class GvPortListEntry : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvPortListEntry(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GvPortListEntry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GvPortListEntry() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_GvPortListEntry(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int id {
    set {
      C4dApiPINVOKE.GvPortListEntry_id_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvPortListEntry_id_get(swigCPtr);
      return ret;
    } 
  }

  public GvPortListEntry(int t_id) : this(C4dApiPINVOKE.new_GvPortListEntry(t_id), true) {
  }

}

}
