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

public class PickSessionDataStruct : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PickSessionDataStruct(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PickSessionDataStruct obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~PickSessionDataStruct() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_PickSessionDataStruct(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public AtomArray active {
    set {
      C4dApiPINVOKE.PickSessionDataStruct_active_set(swigCPtr, AtomArray.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.PickSessionDataStruct_active_get(swigCPtr);
      AtomArray ret = (cPtr == IntPtr.Zero) ? null : new AtomArray(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_LONG_p_q_const__PickSessionDataStruct__void callback {
    set {
      C4dApiPINVOKE.PickSessionDataStruct_callback_set(swigCPtr, SWIGTYPE_p_f_LONG_p_q_const__PickSessionDataStruct__void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.PickSessionDataStruct_callback_get(swigCPtr);
      SWIGTYPE_p_f_LONG_p_q_const__PickSessionDataStruct__void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_f_LONG_p_q_const__PickSessionDataStruct__void(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void userdata {
    set {
      C4dApiPINVOKE.PickSessionDataStruct_userdata_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.PickSessionDataStruct_userdata_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public bool multi {
    set {
      C4dApiPINVOKE.PickSessionDataStruct_multi_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.PickSessionDataStruct_multi_get(swigCPtr);
      return ret;
    } 
  }

  public PickSessionDataStruct() : this(C4dApiPINVOKE.new_PickSessionDataStruct(), true) {
  }

}

}