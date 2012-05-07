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

public class GvDynamicData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvDynamicData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GvDynamicData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GvDynamicData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_GvDynamicData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public GvDynamicData() : this(C4dApiPINVOKE.new_GvDynamicData(), true) {
  }

  public SWIGTYPE_p_void data {
    set {
      C4dApiPINVOKE.GvDynamicData_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.GvDynamicData_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public GvDataInfo info {
    set {
      C4dApiPINVOKE.GvDynamicData_info_set(swigCPtr, GvDataInfo.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.GvDynamicData_info_get(swigCPtr);
      GvDataInfo ret = (cPtr == IntPtr.Zero) ? null : new GvDataInfo(cPtr, false);
      return ret;
    } 
  }

  public int cpu_count {
    set {
      C4dApiPINVOKE.GvDynamicData_cpu_count_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvDynamicData_cpu_count_get(swigCPtr);
      return ret;
    } 
  }

}

}