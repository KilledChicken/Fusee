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

public class HierarchyHelp : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HierarchyHelp(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(HierarchyHelp obj) {
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

  public double GetLOD() {
    double ret = C4dApiPINVOKE.HierarchyHelp_GetLOD(swigCPtr);
    return ret;
  }

  public BUILDFLAGS GetBuildFlags() {
    BUILDFLAGS ret = (BUILDFLAGS)C4dApiPINVOKE.HierarchyHelp_GetBuildFlags(swigCPtr);
    return ret;
  }

  public Fusee.Math.Core.Matrix4D /* constMatrix&_cstype_out */ GetMg()  {  /* <constMatrix&_csout> */
      IntPtr p_ret = C4dApiPINVOKE.HierarchyHelp_GetMg(swigCPtr);
      Fusee.Math.Core.Matrix4D ret;
      unsafe {ret = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D((double *)p_ret);}
      return ret;
   } /* </constMatrix&_csout> */ 

  public BaseThread GetThread() {
    IntPtr cPtr = C4dApiPINVOKE.HierarchyHelp_GetThread(swigCPtr);
    BaseThread ret = (cPtr == IntPtr.Zero) ? null : new BaseThread(cPtr, false);
    return ret;
  }

  public BaseDocument GetDocument() {
    IntPtr cPtr = C4dApiPINVOKE.HierarchyHelp_GetDocument(swigCPtr);
    BaseDocument ret = (cPtr == IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
    return ret;
  }

}

}
