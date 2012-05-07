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

public class NotifyEventCopy : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NotifyEventCopy(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NotifyEventCopy obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NotifyEventCopy() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_NotifyEventCopy(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public NotifyEventCopy() : this(C4dApiPINVOKE.new_NotifyEventCopy(), true) {
  }

  public BaseList2D cpy_dst {
    set {
      C4dApiPINVOKE.NotifyEventCopy_cpy_dst_set(swigCPtr, BaseList2D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NotifyEventCopy_cpy_dst_get(swigCPtr);
      BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
      return ret;
    } 
  }

  public COPYFLAGS cpy_flags {
    set {
      C4dApiPINVOKE.NotifyEventCopy_cpy_flags_set(swigCPtr, (int)value);
    } 
    get {
      COPYFLAGS ret = (COPYFLAGS)C4dApiPINVOKE.NotifyEventCopy_cpy_flags_get(swigCPtr);
      return ret;
    } 
  }

  public AliasTrans cpy_trans {
    set {
      C4dApiPINVOKE.NotifyEventCopy_cpy_trans_set(swigCPtr, AliasTrans.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NotifyEventCopy_cpy_trans_get(swigCPtr);
      AliasTrans ret = (cPtr == IntPtr.Zero) ? null : new AliasTrans(cPtr, false);
      return ret;
    } 
  }

}

}