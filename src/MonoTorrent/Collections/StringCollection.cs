

using System;
using System.Text;
using System.Collections;
#if NET_2_0
using System.Collections.Generic;
#endif

namespace MonoTorrent
{
    public class stringCollection : MonoTorrentCollectionBase
    {
        #region Private Fields

#if NET_2_0
        private List<string> list;
#else
        private ArrayList list;
#endif

        #endregion Private Fields


        #region Constructors

        public stringCollection()
        {
#if NET_2_0
            list = new List<string>();
#else
            list = new ArrayList();
#endif
        }

        public stringCollection(int capacity)
        {
#if NET_2_0
            list = new List<string>(capacity);
#else
            list = new ArrayList(capacity);
#endif
        }

        #endregion


        #region Methods

        public string this[int index]
        {
            get { return (string)list[index]; }
            set { list[index] = value; }
        }

        public int Add(string value)
        {
#if NET_2_0
            list.Add(value);
            return list.Count;
#else
            return this.list.Add(value);
#endif
        }

        public void Clear()
        {
            this.list.Clear();
        }

        public MonoTorrentCollectionBase Clone()
        {
            stringCollection clone = new stringCollection(list.Count);
            for (int i = 0; i < list.Count; i++)
                clone.Add(this[i]);
            return clone;
        }

        public bool Contains(string value)
        {
            return list.Contains(value);
        }

        public void CopyTo(Array array, int index)
        {
            ((IList)list).CopyTo(array, index);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(string value)
        {
            return list.IndexOf(value);
        }

        public void Insert(int index, string value)
        {
            list.Insert(index, value);
        }

        public bool IsSynchronized
        {
            get { return ((IList)list).IsSynchronized; }
        }

        public void Remove(string value)
        {
            list.Remove(value);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        public object SyncRoot
        {
            get { return ((IList)list).SyncRoot; }
        }

        #endregion Methods


        #region Explicit Implementation

        int IList.Add(object value)
        {
            return Add((string)value);
        }

        int IList.IndexOf(object value)
        {
            return IndexOf((string)value);
        }

        bool IList.Contains(object value)
        {
            return Contains((string)value);
        }

        void IList.Insert(int index, object value)
        {
            Insert(index, (string)value);
        }

        bool IList.IsFixedSize
        {
            get { return ((IList)list).IsFixedSize; }
        }

        bool IList.IsReadOnly
        {
            get { return ((IList)list).IsReadOnly; }

        }

        void IList.Remove(object value)
        {
            Remove((string)value);
        }

        object IList.this[int index]
        {
            get { return this[index]; }
            set { this[index] = (string)value; }
        }

        #endregion
    }
}