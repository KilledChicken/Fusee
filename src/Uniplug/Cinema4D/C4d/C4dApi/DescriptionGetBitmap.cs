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

public class DescriptionGetBitmap : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DescriptionGetBitmap(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DescriptionGetBitmap obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DescriptionGetBitmap() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_DescriptionGetBitmap(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public DescID id {
    set {
      C4dApiPINVOKE.DescriptionGetBitmap_id_set(swigCPtr, DescID.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.DescriptionGetBitmap_id_get(swigCPtr);
      DescID ret = (cPtr == IntPtr.Zero) ? null : new DescID(cPtr, false);
      return ret;
    } 
  }

  public BaseBitmap bmp {
    set {
      C4dApiPINVOKE.DescriptionGetBitmap_bmp_set(swigCPtr, BaseBitmap.getCPtr(value));
    } 
    get {
      IntPtr cPtr = C4dApiPINVOKE.DescriptionGetBitmap_bmp_get(swigCPtr);
      BaseBitmap ret = (cPtr == IntPtr.Zero) ? null : new BaseBitmap(cPtr, false);
      return ret;
    } 
  }

  public ICONDATAFLAGS bmpflags {
    set {
      C4dApiPINVOKE.DescriptionGetBitmap_bmpflags_set(swigCPtr, (int)value);
    } 
    get {
      ICONDATAFLAGS ret = (ICONDATAFLAGS)C4dApiPINVOKE.DescriptionGetBitmap_bmpflags_get(swigCPtr);
      return ret;
    } 
  }

  public DescriptionGetBitmap() : this(C4dApiPINVOKE.new_DescriptionGetBitmap(), true) {
  }

}

}
