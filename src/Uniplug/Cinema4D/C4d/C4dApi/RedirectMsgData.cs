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

public class RedirectMsgData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RedirectMsgData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(RedirectMsgData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~RedirectMsgData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_RedirectMsgData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int type {
    set {
      C4dApiPINVOKE.RedirectMsgData_type_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.RedirectMsgData_type_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void data {
    set {
      C4dApiPINVOKE.RedirectMsgData_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.RedirectMsgData_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public BaseList2D bl {
    set {
      C4dApiPINVOKE.RedirectMsgData_bl_set(swigCPtr, BaseList2D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.RedirectMsgData_bl_get(swigCPtr);
      BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
      return ret;
    } 
  }

  public int flags {
    set {
      C4dApiPINVOKE.RedirectMsgData_flags_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.RedirectMsgData_flags_get(swigCPtr);
      return ret;
    } 
  }

  public RedirectMsgData() : this(C4dApiPINVOKE.new_RedirectMsgData(), true) {
  }

}

}