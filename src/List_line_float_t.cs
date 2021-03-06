//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class List_line_float_t : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<line_float_t>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public List_line_float_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(List_line_float_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~List_line_float_t() {
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
          edlinesPINVOKE.delete_List_line_float_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public List_line_float_t(global::System.Collections.IEnumerable c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (line_float_t element in c) {
      this.Add(element);
    }
  }

  public List_line_float_t(global::System.Collections.Generic.IEnumerable<line_float_t> c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (line_float_t element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public line_float_t this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(line_float_t[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(line_float_t[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, line_float_t[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  public line_float_t[] ToArray() {
    line_float_t[] array = new line_float_t[this.Count];
    this.CopyTo(array);
    return array;
  }

  global::System.Collections.Generic.IEnumerator<line_float_t> global::System.Collections.Generic.IEnumerable<line_float_t>.GetEnumerator() {
    return new List_line_float_tEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new List_line_float_tEnumerator(this);
  }

  public List_line_float_tEnumerator GetEnumerator() {
    return new List_line_float_tEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class List_line_float_tEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<line_float_t>
  {
    private List_line_float_t collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public List_line_float_tEnumerator(List_line_float_t collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public line_float_t Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (line_float_t)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    edlinesPINVOKE.List_line_float_t_Clear(swigCPtr);
  }

  public void Add(line_float_t x) {
    edlinesPINVOKE.List_line_float_t_Add(swigCPtr, line_float_t.getCPtr(x));
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = edlinesPINVOKE.List_line_float_t_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = edlinesPINVOKE.List_line_float_t_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    edlinesPINVOKE.List_line_float_t_reserve(swigCPtr, n);
  }

  public List_line_float_t() : this(edlinesPINVOKE.new_List_line_float_t__SWIG_0(), true) {
  }

  public List_line_float_t(List_line_float_t other) : this(edlinesPINVOKE.new_List_line_float_t__SWIG_1(List_line_float_t.getCPtr(other)), true) {
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public List_line_float_t(int capacity) : this(edlinesPINVOKE.new_List_line_float_t__SWIG_2(capacity), true) {
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  private line_float_t getitemcopy(int index) {
    line_float_t ret = new line_float_t(edlinesPINVOKE.List_line_float_t_getitemcopy(swigCPtr, index), true);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private line_float_t getitem(int index) {
    line_float_t ret = new line_float_t(edlinesPINVOKE.List_line_float_t_getitem(swigCPtr, index), false);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, line_float_t val) {
    edlinesPINVOKE.List_line_float_t_setitem(swigCPtr, index, line_float_t.getCPtr(val));
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(List_line_float_t values) {
    edlinesPINVOKE.List_line_float_t_AddRange(swigCPtr, List_line_float_t.getCPtr(values));
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public List_line_float_t GetRange(int index, int count) {
    global::System.IntPtr cPtr = edlinesPINVOKE.List_line_float_t_GetRange(swigCPtr, index, count);
    List_line_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new List_line_float_t(cPtr, true);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, line_float_t x) {
    edlinesPINVOKE.List_line_float_t_Insert(swigCPtr, index, line_float_t.getCPtr(x));
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, List_line_float_t values) {
    edlinesPINVOKE.List_line_float_t_InsertRange(swigCPtr, index, List_line_float_t.getCPtr(values));
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    edlinesPINVOKE.List_line_float_t_RemoveAt(swigCPtr, index);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    edlinesPINVOKE.List_line_float_t_RemoveRange(swigCPtr, index, count);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public static List_line_float_t Repeat(line_float_t value, int count) {
    global::System.IntPtr cPtr = edlinesPINVOKE.List_line_float_t_Repeat(line_float_t.getCPtr(value), count);
    List_line_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new List_line_float_t(cPtr, true);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    edlinesPINVOKE.List_line_float_t_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    edlinesPINVOKE.List_line_float_t_Reverse__SWIG_1(swigCPtr, index, count);
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, List_line_float_t values) {
    edlinesPINVOKE.List_line_float_t_SetRange(swigCPtr, index, List_line_float_t.getCPtr(values));
    if (edlinesPINVOKE.SWIGPendingException.Pending) throw edlinesPINVOKE.SWIGPendingException.Retrieve();
  }

}
