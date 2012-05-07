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

public class NgonNeighbor : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NgonNeighbor(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NgonNeighbor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NgonNeighbor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_NgonNeighbor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int segcnt {
    set {
      C4dApiPINVOKE.NgonNeighbor_segcnt_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.NgonNeighbor_segcnt_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_NgonNeighbor__NgonNeighborSegment segments {
    set {
      C4dApiPINVOKE.NgonNeighbor_segments_set(swigCPtr, SWIGTYPE_p_NgonNeighbor__NgonNeighborSegment.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.NgonNeighbor_segments_get(swigCPtr);
      SWIGTYPE_p_NgonNeighbor__NgonNeighborSegment ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_NgonNeighbor__NgonNeighborSegment(cPtr, false);
      return ret;
    } 
  }

  public NgonNeighbor() : this(C4dApiPINVOKE.new_NgonNeighbor(), true) {
  }

}

}