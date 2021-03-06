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

public class CameraObject : BaseObject {
  private HandleRef swigCPtr;

  internal CameraObject(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.CameraObject_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CameraObject obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public int GetProjection() {
    int ret = C4dApiPINVOKE.CameraObject_GetProjection(swigCPtr);
    return ret;
  }

  public double GetFocus() {
    double ret = C4dApiPINVOKE.CameraObject_GetFocus(swigCPtr);
    return ret;
  }

  public double GetZoom() {
    double ret = C4dApiPINVOKE.CameraObject_GetZoom(swigCPtr);
    return ret;
  }

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ GetOffset()  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.CameraObject_GetOffset(swigCPtr);
      return ret;
   } /* <Vector_csout> */ 

  public double GetAperture() {
    double ret = C4dApiPINVOKE.CameraObject_GetAperture(swigCPtr);
    return ret;
  }

  public bool SetProjection(int projection) {
    bool ret = C4dApiPINVOKE.CameraObject_SetProjection(swigCPtr, projection);
    return ret;
  }

  public bool SetFocus(double v) {
    bool ret = C4dApiPINVOKE.CameraObject_SetFocus(swigCPtr, v);
    return ret;
  }

  public bool SetAperture(double v) {
    bool ret = C4dApiPINVOKE.CameraObject_SetAperture(swigCPtr, v);
    return ret;
  }

  public bool SetZoom(double zoom) {
    bool ret = C4dApiPINVOKE.CameraObject_SetZoom(swigCPtr, zoom);
    return ret;
  }

  public bool SetOffset(Fusee.Math.Core.Vector3D /* constVector&_cstype */ offset) {
    bool ret = C4dApiPINVOKE.CameraObject_SetOffset(swigCPtr, ref offset /* constVector&_csin */);
    return ret;
  }

  public int StereoGetCameraCount(BaseDocument doc, BaseDraw bd, RenderData rd, int flags) {
    int ret = C4dApiPINVOKE.CameraObject_StereoGetCameraCount(swigCPtr, BaseDocument.getCPtr(doc), BaseDraw.getCPtr(bd), RenderData.getCPtr(rd), flags);
    return ret;
  }

  public bool StereoGetCameraInfo(BaseDocument doc, BaseDraw bd, RenderData rd, int n, SWIGTYPE_p_StereoCameraInfo info, int flags) {
    bool ret = C4dApiPINVOKE.CameraObject_StereoGetCameraInfo(swigCPtr, BaseDocument.getCPtr(doc), BaseDraw.getCPtr(bd), RenderData.getCPtr(rd), n, SWIGTYPE_p_StereoCameraInfo.getCPtr(info), flags);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static CameraObject Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.CameraObject_Alloc();
    CameraObject ret = (cPtr == IntPtr.Zero) ? null : new CameraObject(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_CameraObject bl) {
    C4dApiPINVOKE.CameraObject_Free(SWIGTYPE_p_p_CameraObject.getCPtr(bl));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
