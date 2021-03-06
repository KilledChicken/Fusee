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

public class NotifyEventData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NotifyEventData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NotifyEventData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NotifyEventData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_NotifyEventData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public NotifyEventData() : this(C4dApiPINVOKE.new_NotifyEventData(), true) {
  }

  public BaseDocument doc {
    set {
      C4dApiPINVOKE.NotifyEventData_doc_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NotifyEventData_doc_get(swigCPtr);
      BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public BaseList2D bl {
    set {
      C4dApiPINVOKE.NotifyEventData_bl_set(swigCPtr, BaseList2D.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NotifyEventData_bl_get(swigCPtr);
      BaseList2D ret = (cPtr == IntPtr.Zero) ? null : new BaseList2D(cPtr, false);
      return ret;
    } 
  }

  public NOTIFY_EVENT eventid {
    set {
      C4dApiPINVOKE.NotifyEventData_eventid_set(swigCPtr, (int)value);
    } 
    get {
      NOTIFY_EVENT ret = (NOTIFY_EVENT)C4dApiPINVOKE.NotifyEventData_eventid_get(swigCPtr);
      return ret;
    } 
  }

  public BaseContainer user_data {
    set {
      C4dApiPINVOKE.NotifyEventData_user_data_set(swigCPtr, BaseContainer.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NotifyEventData_user_data_get(swigCPtr);
      BaseContainer ret = (cPtr == IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void event_data {
    set {
      C4dApiPINVOKE.NotifyEventData_event_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NotifyEventData_event_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

}

}
