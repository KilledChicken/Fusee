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

public class GvPortDescription : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GvPortDescription(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GvPortDescription obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GvPortDescription() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_GvPortDescription(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public GvPortDescription() : this(C4dApiPINVOKE.new_GvPortDescription(), true) {
  }

  public string /* constString&_cstype */ name {
    set {
      C4dApiPINVOKE.GvPortDescription_name_set(swigCPtr, value);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = C4dApiPINVOKE.GvPortDescription_name_get(swigCPtr);
      if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public GvPortDescFlags flags {
    set {
      C4dApiPINVOKE.GvPortDescription_flags_set(swigCPtr, (int)value);
    } 
    get {
      GvPortDescFlags ret = (GvPortDescFlags)C4dApiPINVOKE.GvPortDescription_flags_get(swigCPtr);
      return ret;
    } 
  }

  public int data_id {
    set {
      C4dApiPINVOKE.GvPortDescription_data_id_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvPortDescription_data_id_get(swigCPtr);
      return ret;
    } 
  }

  public int ports_min {
    set {
      C4dApiPINVOKE.GvPortDescription_ports_min_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvPortDescription_ports_min_get(swigCPtr);
      return ret;
    } 
  }

  public int ports_max {
    set {
      C4dApiPINVOKE.GvPortDescription_ports_max_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvPortDescription_ports_max_get(swigCPtr);
      return ret;
    } 
  }

  public int parent_id {
    set {
      C4dApiPINVOKE.GvPortDescription_parent_id_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.GvPortDescription_parent_id_get(swigCPtr);
      return ret;
    } 
  }

}

}
