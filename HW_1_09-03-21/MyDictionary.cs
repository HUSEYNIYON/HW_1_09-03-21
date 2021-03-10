using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_09_03_21
{
    class MyDictionary<TKey, TValue>
    {
        List<Entry<TKey,TValue>> entries = new List<Entry<TKey,TValue>>();
        public IEnumerator<Entry<TKey,TValue>> GetEnumerator()
        {
            return entries.GetEnumerator();
        }
        public List<TKey> Keys 
        { 
            get 
            {
                List<TKey> n = new List<TKey>();
                for (int i = 0; i < entries.Count; i++)
                {
                    n.Add(entries[i].Key);
                }
                return n; 
            } 
        }
        public List<TValue> Values 
        {
            get 
            {
                List<TValue> n = new List<TValue>();
                for (int i = 0; i < entries.Count; i++)
                {
                    n.Add(entries[i].Value);
                }
                return n; 
            } 
        }
        public int Count { get { return entries.Count; } }
        public TValue this[TKey index]
        {
            get 
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    if (entries[i].Key == (dynamic)index)
                        return entries[i].Value;
                }
                throw new KeyNotFoundException(); 
            }
            set
            {
                int a = entries.Count;
                for (int i = 0; i < entries.Count; i++)
                {

                    if (entries[i].Key == (dynamic)index)
                    {
                        entries[i].Value = value;
                    }
                    else {
                        a--;
                    }
                }
                if(a==0)
                throw new KeyNotFoundException();
            }
        }
        public void Add(TKey keyy,TValue valuee)
        {
            entries.Add(new Entry<TKey, TValue>() { Key = keyy,Value = valuee});
        }
    }
}
