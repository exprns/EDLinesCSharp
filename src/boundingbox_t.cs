//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class boundingbox_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public boundingbox_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(boundingbox_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~boundingbox_t() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          edlinesPINVOKE.delete_boundingbox_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int x {
    set {
      edlinesPINVOKE.boundingbox_t_x_set(swigCPtr, value);
    } 
    get {
      int ret = edlinesPINVOKE.boundingbox_t_x_get(swigCPtr);
      return ret;
    } 
  }

  public int y {
    set {
      edlinesPINVOKE.boundingbox_t_y_set(swigCPtr, value);
    } 
    get {
      int ret = edlinesPINVOKE.boundingbox_t_y_get(swigCPtr);
      return ret;
    } 
  }

  public int width {
    set {
      edlinesPINVOKE.boundingbox_t_width_set(swigCPtr, value);
    } 
    get {
      int ret = edlinesPINVOKE.boundingbox_t_width_get(swigCPtr);
      return ret;
    } 
  }

  public int height {
    set {
      edlinesPINVOKE.boundingbox_t_height_set(swigCPtr, value);
    } 
    get {
      int ret = edlinesPINVOKE.boundingbox_t_height_get(swigCPtr);
      return ret;
    } 
  }

  public boundingbox_t() : this(edlinesPINVOKE.new_boundingbox_t(), true) {
  }

}
