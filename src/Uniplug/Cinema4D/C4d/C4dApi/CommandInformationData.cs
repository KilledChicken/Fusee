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

public class CommandInformationData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CommandInformationData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CommandInformationData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommandInformationData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_CommandInformationData(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public int command_id {
    set {
      C4dApiPINVOKE.CommandInformationData_command_id_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CommandInformationData_command_id_get(swigCPtr);
      return ret;
    } 
  }

  public int managergroup {
    set {
      C4dApiPINVOKE.CommandInformationData_managergroup_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CommandInformationData_managergroup_get(swigCPtr);
      return ret;
    } 
  }

  public int parentid {
    set {
      C4dApiPINVOKE.CommandInformationData_parentid_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.CommandInformationData_parentid_get(swigCPtr);
      return ret;
    } 
  }

  public CommandInformationData() : this(C4dApiPINVOKE.new_CommandInformationData(), true) {
  }

}

}
