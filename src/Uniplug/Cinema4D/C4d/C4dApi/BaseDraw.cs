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

public class BaseDraw : BaseView {
  private HandleRef swigCPtr;

  internal BaseDraw(IntPtr cPtr, bool cMemoryOwn) : base(C4dApiPINVOKE.BaseDraw_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BaseDraw obj) {
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

  public GeData GetParameterData(int id) {
    GeData ret = new GeData(C4dApiPINVOKE.BaseDraw_GetParameterData(swigCPtr, id), true);
    return ret;
  }

  public static BaseDraw Alloc() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDraw_Alloc();
    BaseDraw ret = (cPtr == IntPtr.Zero) ? null : new BaseDraw(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_BaseDraw bd) {
    C4dApiPINVOKE.BaseDraw_Free(SWIGTYPE_p_p_BaseDraw.getCPtr(bd));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetFrameScreen(SWIGTYPE_p_LONG cl, SWIGTYPE_p_LONG ct, SWIGTYPE_p_LONG cr, SWIGTYPE_p_LONG cb) {
    int ret = C4dApiPINVOKE.BaseDraw_GetFrameScreen(swigCPtr, SWIGTYPE_p_LONG.getCPtr(cl), SWIGTYPE_p_LONG.getCPtr(ct), SWIGTYPE_p_LONG.getCPtr(cr), SWIGTYPE_p_LONG.getCPtr(cb));
    return ret;
  }

  public bool HasCameraLink() {
    bool ret = C4dApiPINVOKE.BaseDraw_HasCameraLink(swigCPtr);
    return ret;
  }

  public void SetSceneCamera(BaseObject op, bool animate) {
    C4dApiPINVOKE.BaseDraw_SetSceneCamera__SWIG_0(swigCPtr, BaseObject.getCPtr(op), animate);
  }

  public void SetSceneCamera(BaseObject op) {
    C4dApiPINVOKE.BaseDraw_SetSceneCamera__SWIG_1(swigCPtr, BaseObject.getCPtr(op));
  }

  public BaseObject GetSceneCamera(BaseDocument doc) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDraw_GetSceneCamera(swigCPtr, BaseDocument.getCPtr(doc));
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public BaseObject GetEditorCamera() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDraw_GetEditorCamera(swigCPtr);
    BaseObject ret = (cPtr == IntPtr.Zero) ? null : new BaseObject(cPtr, false);
    return ret;
  }

  public DISPLAYFILTER GetDisplayFilter() {
    DISPLAYFILTER ret = (DISPLAYFILTER)C4dApiPINVOKE.BaseDraw_GetDisplayFilter(swigCPtr);
    return ret;
  }

  public DISPLAYEDITSTATE GetEditState() {
    DISPLAYEDITSTATE ret = (DISPLAYEDITSTATE)C4dApiPINVOKE.BaseDraw_GetEditState(swigCPtr);
    return ret;
  }

  public bool IsViewOpen(BaseDocument doc) {
    bool ret = C4dApiPINVOKE.BaseDraw_IsViewOpen(swigCPtr, BaseDocument.getCPtr(doc));
    return ret;
  }

  public void InitClipbox(int left, int top, int right, int bottom, int flags) {
    C4dApiPINVOKE.BaseDraw_InitClipbox(swigCPtr, left, top, right, bottom, flags);
  }

  public void InitView(BaseContainer camera, ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ op_m, double sv, double pix_x, double pix_y, bool fitview) {
    double[] adbl_op_m;
    unsafe {adbl_op_m = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(op_m);    fixed (double *pdbl_op_m = adbl_op_m) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.BaseDraw_InitView(swigCPtr, BaseContainer.getCPtr(camera), (IntPtr) pdbl_op_m /* constMatrix&_csin */, sv, pix_x, pix_y, fitview);
    } finally {
        // NOP op_m = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_op_m);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public void InitializeView(BaseDocument doc, BaseObject cam, bool editorsv) {
    C4dApiPINVOKE.BaseDraw_InitializeView(swigCPtr, BaseDocument.getCPtr(doc), BaseObject.getCPtr(cam), editorsv);
  }

  public bool AddToPostPass(BaseObject op, BaseDrawHelp bh) {
    bool ret = C4dApiPINVOKE.BaseDraw_AddToPostPass(swigCPtr, BaseObject.getCPtr(op), BaseDrawHelp.getCPtr(bh));
    return ret;
  }

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ GetObjectColor(BaseDrawHelp bh, BaseObject op, bool lines)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseDraw_GetObjectColor__SWIG_0(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), lines);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ GetObjectColor(BaseDrawHelp bh, BaseObject op)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseDraw_GetObjectColor__SWIG_1(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op));
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ CheckColor(Fusee.Math.Core.Vector3D /* constVector&_cstype */ col)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseDraw_CheckColor(swigCPtr, ref col /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public void SetTransparency(int trans) {
    C4dApiPINVOKE.BaseDraw_SetTransparency(swigCPtr, trans);
  }

  public int GetTransparency() {
    int ret = C4dApiPINVOKE.BaseDraw_GetTransparency(swigCPtr);
    return ret;
  }

  public bool PointInRange(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, int x, int y) {
    bool ret = C4dApiPINVOKE.BaseDraw_PointInRange(swigCPtr, ref p /* constVector&_csin */, x, y);
    return ret;
  }

  public void SetPen(Fusee.Math.Core.Vector3D /* constVector&_cstype */ col, int flags) {
    C4dApiPINVOKE.BaseDraw_SetPen__SWIG_0(swigCPtr, ref col /* constVector&_csin */, flags);
  }

  public void SetPen(Fusee.Math.Core.Vector3D /* constVector&_cstype */ col) {
    C4dApiPINVOKE.BaseDraw_SetPen__SWIG_1(swigCPtr, ref col /* constVector&_csin */);
  }

  public void SetPointSize(double pointsize) {
    C4dApiPINVOKE.BaseDraw_SetPointSize(swigCPtr, pointsize);
  }

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ConvertColor(Fusee.Math.Core.Vector3D /* constVector&_cstype */ c)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseDraw_ConvertColor(swigCPtr, ref c /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public Fusee.Math.Core.Vector3D /* Vector_cstype_out */ ConvertColorReverse(Fusee.Math.Core.Vector3D /* constVector&_cstype */ c)  {  /* <Vector_csout> */
      Fusee.Math.Core.Vector3D ret = C4dApiPINVOKE.BaseDraw_ConvertColorReverse(swigCPtr, ref c /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

  public double SimpleShade(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, Fusee.Math.Core.Vector3D /* constVector&_cstype */ n) {
    double ret = C4dApiPINVOKE.BaseDraw_SimpleShade(swigCPtr, ref p /* constVector&_csin */, ref n /* constVector&_csin */);
    return ret;
  }

  public void LineZOffset(int offset) {
    C4dApiPINVOKE.BaseDraw_LineZOffset(swigCPtr, offset);
  }

  public void SetDepth(bool enable) {
    C4dApiPINVOKE.BaseDraw_SetDepth(swigCPtr, enable);
  }

  public void SetMatrix_Projection() {
    C4dApiPINVOKE.BaseDraw_SetMatrix_Projection(swigCPtr);
  }

  public void SetMatrix_Screen() {
    C4dApiPINVOKE.BaseDraw_SetMatrix_Screen__SWIG_0(swigCPtr);
  }

  public void SetMatrix_Screen(int zoffset) {
    C4dApiPINVOKE.BaseDraw_SetMatrix_Screen__SWIG_1(swigCPtr, zoffset);
  }

  public void SetMatrix_Screen(int zoffset, SWIGTYPE_p_Matrix4 m) {
    C4dApiPINVOKE.BaseDraw_SetMatrix_Screen__SWIG_2(swigCPtr, zoffset, SWIGTYPE_p_Matrix4.getCPtr(m));
  }

  public void SetMatrix_Camera() {
    C4dApiPINVOKE.BaseDraw_SetMatrix_Camera(swigCPtr);
  }

  public void SetMatrix_Matrix(BaseObject op, ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ mg) {
    double[] adbl_mg;
    unsafe {adbl_mg = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(mg);    fixed (double *pdbl_mg = adbl_mg) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.BaseDraw_SetMatrix_Matrix__SWIG_0(swigCPtr, BaseObject.getCPtr(op), (IntPtr) pdbl_mg /* constMatrix&_csin */);
    } finally {
        // NOP mg = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_mg);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public void SetMatrix_Matrix(BaseObject op, ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ mg, int zoffset) {
    double[] adbl_mg;
    unsafe {adbl_mg = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(mg);    fixed (double *pdbl_mg = adbl_mg) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.BaseDraw_SetMatrix_Matrix__SWIG_1(swigCPtr, BaseObject.getCPtr(op), (IntPtr) pdbl_mg /* constMatrix&_csin */, zoffset);
    } finally {
        // NOP mg = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_mg);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public void LineStripBegin() {
    C4dApiPINVOKE.BaseDraw_LineStripBegin(swigCPtr);
  }

  public void LineStrip(Fusee.Math.Core.Vector3D /* constVector&_cstype */ vp, Fusee.Math.Core.Vector3D /* constVector&_cstype */ vc, int flags) {
    C4dApiPINVOKE.BaseDraw_LineStrip(swigCPtr, ref vp /* constVector&_csin */, ref vc /* constVector&_csin */, flags);
  }

  public void LineStripEnd() {
    C4dApiPINVOKE.BaseDraw_LineStripEnd(swigCPtr);
  }

  public void DrawPoint2D(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p) {
    C4dApiPINVOKE.BaseDraw_DrawPoint2D(swigCPtr, ref p /* constVector&_csin */);
  }

  public void DrawLine2D(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p1, Fusee.Math.Core.Vector3D /* constVector&_cstype */ p2) {
    C4dApiPINVOKE.BaseDraw_DrawLine2D(swigCPtr, ref p1 /* constVector&_csin */, ref p2 /* constVector&_csin */);
  }

  public void DrawHandle2D(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p, DRAWHANDLE type) {
    C4dApiPINVOKE.BaseDraw_DrawHandle2D__SWIG_0(swigCPtr, ref p /* constVector&_csin */, (int)type);
  }

  public void DrawHandle2D(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p) {
    C4dApiPINVOKE.BaseDraw_DrawHandle2D__SWIG_1(swigCPtr, ref p /* constVector&_csin */);
  }

  public void DrawCircle2D(int mx, int my, double rad) {
    C4dApiPINVOKE.BaseDraw_DrawCircle2D(swigCPtr, mx, my, rad);
  }

  public void DrawHandle(Fusee.Math.Core.Vector3D /* constVector&_cstype */ vp, DRAWHANDLE type, int flags) {
    C4dApiPINVOKE.BaseDraw_DrawHandle(swigCPtr, ref vp /* constVector&_csin */, (int)type, flags);
  }

  public void DrawPointArray(int cnt, SWIGTYPE_p_SVector vp, SWIGTYPE_p_SReal vc, int colcnt, SWIGTYPE_p_SVector vn) {
    C4dApiPINVOKE.BaseDraw_DrawPointArray__SWIG_0(swigCPtr, cnt, SWIGTYPE_p_SVector.getCPtr(vp), SWIGTYPE_p_SReal.getCPtr(vc), colcnt, SWIGTYPE_p_SVector.getCPtr(vn));
  }

  public void DrawPointArray(int cnt, SWIGTYPE_p_SVector vp, SWIGTYPE_p_SReal vc, int colcnt) {
    C4dApiPINVOKE.BaseDraw_DrawPointArray__SWIG_1(swigCPtr, cnt, SWIGTYPE_p_SVector.getCPtr(vp), SWIGTYPE_p_SReal.getCPtr(vc), colcnt);
  }

  public void DrawPointArray(int cnt, SWIGTYPE_p_SVector vp, SWIGTYPE_p_SReal vc) {
    C4dApiPINVOKE.BaseDraw_DrawPointArray__SWIG_2(swigCPtr, cnt, SWIGTYPE_p_SVector.getCPtr(vp), SWIGTYPE_p_SReal.getCPtr(vc));
  }

  public void DrawPointArray(int cnt, SWIGTYPE_p_SVector vp) {
    C4dApiPINVOKE.BaseDraw_DrawPointArray__SWIG_3(swigCPtr, cnt, SWIGTYPE_p_SVector.getCPtr(vp));
  }

  public void DrawLine(Fusee.Math.Core.Vector3D /* constVector&_cstype */ p1, Fusee.Math.Core.Vector3D /* constVector&_cstype */ p2, int flags) {
    C4dApiPINVOKE.BaseDraw_DrawLine(swigCPtr, ref p1 /* constVector&_csin */, ref p2 /* constVector&_csin */, flags);
  }

  public void DrawPoly(ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ vp, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ vf, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ vn, int anz, int flags) {
    C4dApiPINVOKE.BaseDraw_DrawPoly(swigCPtr, ref vp /* Vector*&_csin */, ref vf /* Vector*&_csin */, ref vn /* Vector*&_csin */, anz, flags);
  }

  public void DrawTexture(BaseBitmap bmp, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ padr4, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ cadr, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ vnadr, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ uvadr, int pntcnt, DRAW_ALPHA alphamode, DRAW_TEXTUREFLAGS flags) {
    C4dApiPINVOKE.BaseDraw_DrawTexture__SWIG_0(swigCPtr, BaseBitmap.getCPtr(bmp), ref padr4 /* Vector*&_csin */, ref cadr /* Vector*&_csin */, ref vnadr /* Vector*&_csin */, ref uvadr /* Vector*&_csin */, pntcnt, (int)alphamode, (int)flags);
  }

  public void DrawTexture(SWIGTYPE_p_C4DGLuint bmp, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ padr4, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ cadr, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ vnadr, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ uvadr, int pntcnt, DRAW_ALPHA alphamode) {
    C4dApiPINVOKE.BaseDraw_DrawTexture__SWIG_1(swigCPtr, SWIGTYPE_p_C4DGLuint.getCPtr(bmp), ref padr4 /* Vector*&_csin */, ref cadr /* Vector*&_csin */, ref vnadr /* Vector*&_csin */, ref uvadr /* Vector*&_csin */, pntcnt, (int)alphamode);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void DrawCircle(ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ m) {
    double[] adbl_m;
    unsafe {adbl_m = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(m);    fixed (double *pdbl_m = adbl_m) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.BaseDraw_DrawCircle(swigCPtr, (IntPtr) pdbl_m /* constMatrix&_csin */);
    } finally {
        // NOP m = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_m);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public void DrawBox(ref Fusee.Math.Core.Matrix4D /* constMatrix&_cstype */ m, double size, Fusee.Math.Core.Vector3D /* constVector&_cstype */ col, bool wire) {
    double[] adbl_m;
    unsafe {adbl_m = Fusee.Math.ArrayConversion.Convert.Matrix4DToArrayDoubleC4DLayout(m);    fixed (double *pdbl_m = adbl_m) {
    /* constMatrix&_csin_pre */
    try {
      C4dApiPINVOKE.BaseDraw_DrawBox(swigCPtr, (IntPtr) pdbl_m /* constMatrix&_csin */, size, ref col /* constVector&_csin */, wire);
    } finally {
        // NOP m = Fusee.Math.ArrayConversion.Convert.ArrayDoubleC4DLayoutToMatrix4D(pdbl_m);
        /* constMatrix&_csin_post */
    }
} } /* constMatrix&_csin_terminator */
  }

  public void DrawPolygon(ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ p, ref Fusee.Math.Core.Vector3D /* Vector*&_cstype */ f, bool quad) {
    C4dApiPINVOKE.BaseDraw_DrawPolygon(swigCPtr, ref p /* Vector*&_csin */, ref f /* Vector*&_csin */, quad);
  }

  public void DrawSphere(Fusee.Math.Core.Vector3D /* constVector&_cstype */ off, Fusee.Math.Core.Vector3D /* constVector&_cstype */ size, Fusee.Math.Core.Vector3D /* constVector&_cstype */ col, int flags) {
    C4dApiPINVOKE.BaseDraw_DrawSphere(swigCPtr, ref off /* constVector&_csin */, ref size /* constVector&_csin */, ref col /* constVector&_csin */, flags);
  }

  public void DrawArrayEnd() {
    C4dApiPINVOKE.BaseDraw_DrawArrayEnd(swigCPtr);
  }

  public DRAWRESULT DrawPolygonObject(BaseDrawHelp bh, BaseObject op, DRAWOBJECT flags, BaseObject parent, Fusee.Math.Core.Vector3D /* constVector&_cstype */ col) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.BaseDraw_DrawPolygonObject__SWIG_0(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), (int)flags, BaseObject.getCPtr(parent), ref col /* constVector&_csin */);
    return ret;
  }

  public DRAWRESULT DrawPolygonObject(BaseDrawHelp bh, BaseObject op, DRAWOBJECT flags, BaseObject parent) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.BaseDraw_DrawPolygonObject__SWIG_1(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), (int)flags, BaseObject.getCPtr(parent));
    return ret;
  }

  public DRAWRESULT DrawPolygonObject(BaseDrawHelp bh, BaseObject op, DRAWOBJECT flags) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.BaseDraw_DrawPolygonObject__SWIG_2(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), (int)flags);
    return ret;
  }

  public DRAWRESULT DrawObject(BaseDrawHelp bh, BaseObject op, DRAWOBJECT flags, DRAWPASS drawpass, BaseObject parent, Fusee.Math.Core.Vector3D /* constVector&_cstype */ col) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.BaseDraw_DrawObject__SWIG_0(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), (int)flags, (int)drawpass, BaseObject.getCPtr(parent), ref col /* constVector&_csin */);
    return ret;
  }

  public DRAWRESULT DrawObject(BaseDrawHelp bh, BaseObject op, DRAWOBJECT flags, DRAWPASS drawpass, BaseObject parent) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.BaseDraw_DrawObject__SWIG_1(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), (int)flags, (int)drawpass, BaseObject.getCPtr(parent));
    return ret;
  }

  public DRAWRESULT DrawObject(BaseDrawHelp bh, BaseObject op, DRAWOBJECT flags, DRAWPASS drawpass) {
    DRAWRESULT ret = (DRAWRESULT)C4dApiPINVOKE.BaseDraw_DrawObject__SWIG_2(swigCPtr, BaseDrawHelp.getCPtr(bh), BaseObject.getCPtr(op), (int)flags, (int)drawpass);
    return ret;
  }

  public bool DrawScene(int flags) {
    bool ret = C4dApiPINVOKE.BaseDraw_DrawScene(swigCPtr, flags);
    return ret;
  }

  public DISPLAYMODE GetReductionMode() {
    DISPLAYMODE ret = (DISPLAYMODE)C4dApiPINVOKE.BaseDraw_GetReductionMode(swigCPtr);
    return ret;
  }

  public bool InitDrawXORPolyLine() {
    bool ret = C4dApiPINVOKE.BaseDraw_InitDrawXORPolyLine(swigCPtr);
    return ret;
  }

  public void FreeDrawXORPolyLine() {
    C4dApiPINVOKE.BaseDraw_FreeDrawXORPolyLine(swigCPtr);
  }

  public void DrawXORPolyLine(SWIGTYPE_p_SReal p, int cnt) {
    C4dApiPINVOKE.BaseDraw_DrawXORPolyLine(swigCPtr, SWIGTYPE_p_SReal.getCPtr(p), cnt);
  }

  public void BeginDrawXORPolyLine() {
    C4dApiPINVOKE.BaseDraw_BeginDrawXORPolyLine(swigCPtr);
  }

  public void EndDrawXORPolyLine(bool blit) {
    C4dApiPINVOKE.BaseDraw_EndDrawXORPolyLine(swigCPtr, blit);
  }

  public void SetLightList(int mode) {
    C4dApiPINVOKE.BaseDraw_SetLightList(swigCPtr, mode);
  }

  public void InitUndo(BaseDocument doc) {
    C4dApiPINVOKE.BaseDraw_InitUndo(swigCPtr, BaseDocument.getCPtr(doc));
  }

  public void DoUndo(BaseDocument doc) {
    C4dApiPINVOKE.BaseDraw_DoUndo(swigCPtr, BaseDocument.getCPtr(doc));
  }

  public void SetDrawParam(int id, GeData data) {
    C4dApiPINVOKE.BaseDraw_SetDrawParam(swigCPtr, id, GeData.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public GeData GetDrawParam(int id) {
    GeData ret = new GeData(C4dApiPINVOKE.BaseDraw_GetDrawParam(swigCPtr, id), true);
    return ret;
  }

  public bool TestBreak() {
    bool ret = C4dApiPINVOKE.BaseDraw_TestBreak(swigCPtr);
    return ret;
  }

  public OITInfo GetOITInfo() {
    OITInfo ret = new OITInfo(C4dApiPINVOKE.BaseDraw_GetOITInfo(swigCPtr), false);
    return ret;
  }

  public bool GetFullscreenPolygonVectors(SWIGTYPE_p_LONG lAttributeCount, SWIGTYPE_p_p_p_GlVertexBufferAttributeInfo ppAttibuteInfo, SWIGTYPE_p_LONG lVectorInfoCount, SWIGTYPE_p_p_p_GlVertexBufferVectorInfo ppVectorInfo) {
    bool ret = C4dApiPINVOKE.BaseDraw_GetFullscreenPolygonVectors(swigCPtr, SWIGTYPE_p_LONG.getCPtr(lAttributeCount), SWIGTYPE_p_p_p_GlVertexBufferAttributeInfo.getCPtr(ppAttibuteInfo), SWIGTYPE_p_LONG.getCPtr(lVectorInfoCount), SWIGTYPE_p_p_p_GlVertexBufferVectorInfo.getCPtr(ppVectorInfo));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool DrawFullscreenPolygon(int lVectorInfoCount, SWIGTYPE_p_p_GlVertexBufferVectorInfo ppVectorInfo) {
    bool ret = C4dApiPINVOKE.BaseDraw_DrawFullscreenPolygon(swigCPtr, lVectorInfoCount, SWIGTYPE_p_p_GlVertexBufferVectorInfo.getCPtr(ppVectorInfo));
    return ret;
  }

  public int GetGlLightCount() {
    int ret = C4dApiPINVOKE.BaseDraw_GetGlLightCount(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_GlLight GetGlLight(int lIndex) {
    IntPtr cPtr = C4dApiPINVOKE.BaseDraw_GetGlLight(swigCPtr, lIndex);
    SWIGTYPE_p_GlLight ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_GlLight(cPtr, false);
    return ret;
  }

  public bool GetDrawStatistics(BaseContainer bc) {
    bool ret = C4dApiPINVOKE.BaseDraw_GetDrawStatistics(swigCPtr, BaseContainer.getCPtr(bc));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Matrix4 GetViewMatrix(int n) {
    SWIGTYPE_p_Matrix4 ret = new SWIGTYPE_p_Matrix4(C4dApiPINVOKE.BaseDraw_GetViewMatrix(swigCPtr, n), false);
    return ret;
  }

  public SWIGTYPE_p_EditorWindow GetEditorWindow() {
    IntPtr cPtr = C4dApiPINVOKE.BaseDraw_GetEditorWindow(swigCPtr);
    SWIGTYPE_p_EditorWindow ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_EditorWindow(cPtr, false);
    return ret;
  }

  public void SetTexture(BaseBitmap bm, bool tile, DRAW_ALPHA alphamode, DRAW_TEXTUREFLAGS flags) {
    C4dApiPINVOKE.BaseDraw_SetTexture(swigCPtr, BaseBitmap.getCPtr(bm), tile, (int)alphamode, (int)flags);
  }

  public void OverrideCamera(SWIGTYPE_p_StereoCameraInfo si) {
    C4dApiPINVOKE.BaseDraw_OverrideCamera(swigCPtr, SWIGTYPE_p_StereoCameraInfo.getCPtr(si));
  }

}

}
