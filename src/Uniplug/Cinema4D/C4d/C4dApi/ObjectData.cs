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

public class ObjectData : NodeData {
  private HandleRef swigCPtr;

  internal ObjectData(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.ObjectData_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ObjectData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ObjectData() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ObjectData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void GetDimension(BaseObject op, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ mp, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ rad) {
    C4dApiPINVOKE.ObjectData_GetDimension(swigCPtr, BaseObject.getCPtr(op), ref mp /* Vector*&_csin */, ref rad /* Vector*&_csin */);
  }

  public virtual DRAWRESULT Draw(BaseObject op, DRAWPASS drawpass, BaseDraw bd, BaseDrawHelp bh) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.ObjectData_Draw(swigCPtr, BaseObject.getCPtr(op), (int)drawpass, BaseDraw.getCPtr(bd), BaseDrawHelp.getCPtr(bh));
    return ret;
  }

  public virtual int DetectHandle(BaseObject op, BaseDraw bd, int x, int y, QUALIFIER qualifier) {
    int ret = C4dApiPINVOKE.ObjectData_DetectHandle(swigCPtr, BaseObject.getCPtr(op), BaseDraw.getCPtr(bd), x, y, (int)qualifier);
    return ret;
  }

  public virtual bool MoveHandle(BaseObject op, BaseObject undo, Fusee.Math.Core.Vector3D /* constVector&_cstype */ mouse_pos, int hit_id, QUALIFIER qualifier, BaseDraw bd) {
    bool ret = C4dApiPINVOKE.ObjectData_MoveHandle(swigCPtr, BaseObject.getCPtr(op), BaseObject.getCPtr(undo), ref mouse_pos /* constVector&_csin */, hit_id, (int)qualifier, BaseDraw.getCPtr(bd));
    return ret;
  }

  public virtual bool AddToExecution(BaseObject op, PriorityList list) {
    bool ret = C4dApiPINVOKE.ObjectData_AddToExecution(swigCPtr, BaseObject.getCPtr(op), PriorityList.getCPtr(list));
    return ret;
  }

  public virtual EXECUTIONRESULT Execute(BaseObject op, BaseDocument doc, BaseThread bt, int priority, EXECUTIONFLAGS flags) {
    EXECUTIONRESULT ret = (EXECUTIONRESULT)C4dApiPINVOKE.ObjectData_Execute(swigCPtr, BaseObject.getCPtr(op), BaseDocument.getCPtr(doc), BaseThread.getCPtr(bt), priority, (int)flags);
    return ret;
  }

  public virtual void GetModelingAxis(BaseObject op, BaseDocument doc, ref Fusee.Math.Core.Matrix4D /* Matrix*&_cstype */ axis) {
    double[] adbl_axis;
    unsafe {adbl_axis = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(axis);    fixed (double *pdbl_axis = adbl_axis) {
    /* Matrix*&_csin_pre */
    try {
      C4dApiPINVOKE.ObjectData_GetModelingAxis(swigCPtr, BaseObject.getCPtr(op), BaseDocument.getCPtr(doc), (IntPtr) pdbl_axis /* Matrix*&_csin */);
    } finally {
        axis = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_axis);
        /* Matrix*&_csin_post */
    }
} } /* Matrix*&_csin_terminator */
  }

  public virtual BaseObject GetVirtualObjects(BaseObject op, HierarchyHelp hh) {
    IntPtr cPtr = C4dApiPINVOKE.ObjectData_GetVirtualObjects(swigCPtr, BaseObject.getCPtr(op), HierarchyHelp.getCPtr(hh));
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public virtual bool ModifyObject(BaseObject mod, BaseDocument doc, BaseObject op, ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ op_mg, ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ mod_mg, double lod, int flags, BaseThread thread) {
    double[] adbl_op_mg;
    unsafe {adbl_op_mg = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(op_mg);    fixed (double *pdbl_op_mg = adbl_op_mg) {
    /* constMatrix&_csin_pre */
    double[] adbl_mod_mg;
    unsafe {adbl_mod_mg = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(mod_mg);    fixed (double *pdbl_mod_mg = adbl_mod_mg) {
    /* constMatrix&_csin_pre */
    try {
      bool ret = C4dApiPINVOKE.ObjectData_ModifyObject(swigCPtr, BaseObject.getCPtr(mod), BaseDocument.getCPtr(doc), BaseObject.getCPtr(op), (IntPtr) pdbl_op_mg /* constMatrix&_csin */, (IntPtr) pdbl_mod_mg /* constMatrix&_csin */, lod, flags, BaseThread.getCPtr(thread));
      return ret;
    } finally {
        // NOP op_mg = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_op_mg);
        /* constMatrix&_csin_post */
        // NOP mod_mg = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_mod_mg);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
} } /* constMatrix&_csin_terminator */
  }

  public virtual void CheckDirty(BaseObject op, BaseDocument doc) {
    C4dApiPINVOKE.ObjectData_CheckDirty(swigCPtr, BaseObject.getCPtr(op), BaseDocument.getCPtr(doc));
  }

  public virtual SplineObject GetContour(BaseObject op, BaseDocument doc, double lod, BaseThread bt) {
    IntPtr cPtr = C4dApiPINVOKE.ObjectData_GetContour(swigCPtr, BaseObject.getCPtr(op), BaseDocument.getCPtr(doc), lod, BaseThread.getCPtr(bt));
    SplineObject ret = (cPtr == IntPtr.Zero) ? null : new SplineObject(cPtr, false);
    return ret;
  }

  public virtual void ModifyParticles(BaseObject op, SWIGTYPE_p_Particle pp, SWIGTYPE_p_BaseParticle ss, int pcnt, double diff) {
    C4dApiPINVOKE.ObjectData_ModifyParticles(swigCPtr, BaseObject.getCPtr(op), SWIGTYPE_p_Particle.getCPtr(pp), SWIGTYPE_p_BaseParticle.getCPtr(ss), pcnt, diff);
  }

  public virtual int GetHandleCount(BaseObject op) {
    int ret = C4dApiPINVOKE.ObjectData_GetHandleCount(swigCPtr, BaseObject.getCPtr(op));
    return ret;
  }

  public virtual void GetHandle(BaseObject op, int i, HandleInfo info) {
    C4dApiPINVOKE.ObjectData_GetHandle(swigCPtr, BaseObject.getCPtr(op), i, HandleInfo.getCPtr(info));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetHandle(BaseObject op, int i, Fusee.Math.Core.Vector3D /* Vectorcstype */ p, HandleInfo info) {
    C4dApiPINVOKE.ObjectData_SetHandle(swigCPtr, BaseObject.getCPtr(op), i, p /* Vector_csin */, HandleInfo.getCPtr(info));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public ObjectData() : this(C4dApiPINVOKE.new_ObjectData(), true) {
  }

}

}
