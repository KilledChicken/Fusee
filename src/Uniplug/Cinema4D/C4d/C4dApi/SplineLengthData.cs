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

public class SplineLengthData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SplineLengthData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SplineLengthData obj) {
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

  public bool Init(SplineObject op, int segment, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ padr) {
    bool ret = C4dApiPINVOKE.SplineLengthData_Init__SWIG_0(swigCPtr, SplineObject.getCPtr(op), segment, ref padr /* Vector*&_csin */);
    return ret;
  }

  public bool Init(SplineObject op, int segment) {
    bool ret = C4dApiPINVOKE.SplineLengthData_Init__SWIG_1(swigCPtr, SplineObject.getCPtr(op), segment);
    return ret;
  }

  public bool Init(SplineObject op) {
    bool ret = C4dApiPINVOKE.SplineLengthData_Init__SWIG_2(swigCPtr, SplineObject.getCPtr(op));
    return ret;
  }

  public double UniformToNatural(double t) {
    double ret = C4dApiPINVOKE.SplineLengthData_UniformToNatural(swigCPtr, t);
    return ret;
  }

  public double GetLength() {
    double ret = C4dApiPINVOKE.SplineLengthData_GetLength(swigCPtr);
    return ret;
  }

  public double GetSegmentLength(int a, int b) {
    double ret = C4dApiPINVOKE.SplineLengthData_GetSegmentLength(swigCPtr, a, b);
    return ret;
  }

  public static SplineLengthData Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.SplineLengthData_Alloc();
    SplineLengthData ret = (cPtr == IntPtr.Zero) ? null : new SplineLengthData(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_SplineLengthData bl) {
    C4dApiPINVOKE.SplineLengthData_Free(SWIGTYPE_p_p_SplineLengthData.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
