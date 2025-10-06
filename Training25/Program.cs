// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program for the implementation of a custom MyList<T> class using arrays as the underlying data structure.
// The MyList<T> starts with an initial capacity of 4 and doubles its capacity when needed.
// ------------------------------------------------------------------------------------------------
using System.Collections;

namespace Training25;
internal class Program {
   static void Main () => TestMyList ();

   /// <summary>Method to test the implementation of MyList class</summary>
   static void TestMyList () {
      var list = new MyList<int> { 10, 20, 30, 40 };
      Console.WriteLine ($"Initial List: {string.Join (" ", list)}\nCount: {list.Count}\nCapacity: {list.Capacity}");
      list.Add (50);
      Console.WriteLine ($"\nAfter adding 50: {string.Join (" ", list)}\nCount: {list.Count}\nCapacity: {list.Capacity}");
      list.Remove (30);
      Console.WriteLine ($"\nAfter removing 30: {string.Join (" ", list)}");
      list.Insert (2, 25);
      Console.WriteLine ($"\nAfter inserting 25 at index 2: {string.Join (" ", list)}");
      list.RemoveAt (0);
      Console.WriteLine ($"\nAfter removing item at index 0: {string.Join (" ", list)}");
      list.Clear ();
      Console.WriteLine ($"\nAfter clearing the list:\nCount: {list.Count}");
   }

   #region Class MyList<T>
   /// <summary>Represents a list of objects that can be accessed by index. 
   /// Provides methods to add, remove, and manipulate lists.</summary>
   class MyList<T> : IEnumerable<T> {
      #region Constructor ----------------------------------------
      /// <summary>Construct a list with an initial capacity of 4.</summary>
      public MyList () {
         mArrayList = new T[4];
         mCount = 0;
      }
      #endregion

      #region Properties ----------------------------------------
      /// <summary>Returns the number of elements in the list.</summary>
      public int Count => mCount;
      /// <summary>Returns the capacity of the list.</summary>
      public int Capacity => mArrayList.Length;
      /// <summary>Gets or sets the element at the specified index.</summary>
      public T this[int index] {
         get {
            if (index < 0 || index >= Count) throw new IndexOutOfRangeException ();
            return mArrayList[index];
         }
         set {
            if (index < 0 || index > Capacity) throw new IndexOutOfRangeException ();
            mArrayList[index] = value;
         }
      }
      #endregion

      #region Interface Implementation ----------------------------------------
      /// <summary>Returns each element in the internal collection using yield return.</summary>
      public IEnumerator<T> GetEnumerator () {
         for (int i = 0; i < mCount; i++)
            yield return mArrayList[i];
      }
      IEnumerator IEnumerable.GetEnumerator () => GetEnumerator ();
      #endregion

      #region Methods ----------------------------------------
      /// <summary>Adds an item at the end of the list.</summary>
      public void Add (T item) {
         if (item is null) throw new ArgumentNullException ();
         if (mCount == Capacity)
            // Double the capacity if the array is full
            Array.Resize (ref mArrayList, Capacity * 2);
         mArrayList[mCount++] = item;
      }

      /// <summary>Removes the first occurrence of specified item from the list.</summary>
      public bool Remove (T item) {
         var index = Array.IndexOf (mArrayList, item);
         if (index is -1) return false;
         for (int i = index; i < mCount; i++)
            mArrayList[i] = mArrayList[i + 1];
         mCount--;
         return true;
      }

      /// <summary>Removes all items from the list.</summary>
      public void Clear () {
         if (mCount == 0) return;
         Array.Clear (mArrayList, 0, mCount);
         mCount = 0;
      }

      /// <summary>Inserts an item at the specified index.</summary>
      public void Insert (int index, T item) {
         if (item is null) throw new ArgumentNullException ();
         if (index < 0 || index > mCount) throw new ArgumentOutOfRangeException ();
         if (mCount == Capacity)
            Array.Resize (ref mArrayList, Capacity * 2);
         for (int i = mCount; i > index; i--)
            mArrayList[i] = mArrayList[i - 1];
         mArrayList[index] = item;
         mCount++;
      }

      /// <summary>Removes the item from the specified index.</summary>
      public void RemoveAt (int index) {
         if (index < 0 || index > mCount - 1) throw new ArgumentOutOfRangeException ();
         for (int i = index; i < mCount - 1; i++)
            mArrayList[i] = mArrayList[i + 1];
         mCount--;
      }
      #endregion

      #region Private variables ----------------------------------------
      // Private variables for creating an array-based list and tracking the count of elements.
      T[] mArrayList;
      int mCount;
      #endregion
   }
   #endregion
}