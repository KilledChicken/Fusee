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

public class PointTag : VariableTag {
  private HandleRef swigCPtr;

  internal PointTag(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.PointTag_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(PointTag obj) {
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

  public SWIGTYPE_p_Vector GetDataAddressR() {
    IntPtr cPtr = C4dApiPINVOKE.PointTag_GetDataAddressR(swigCPtr);
    SWIGTYPE_p_Vector ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Vector(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_Vector GetDataAddressW() {
    IntPtr cPtr = C4dApiPINVOKE.PointTag_GetDataAddressW(swigCPtr);
    SWIGTYPE_p_Vector ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_Vector(cPtr, false);
    return ret;
  }

}

}