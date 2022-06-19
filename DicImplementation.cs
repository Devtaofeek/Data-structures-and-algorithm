using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithm
{
    public class DicImplementation
    {
        LinkedList<Entry>[] arr = new LinkedList<Entry>[10];
        private int Hash(int key)
        {
            return key % arr.Length;
        }

        private void Add(int key, string value)
        {
            var ll = new LinkedList<Entry>();
            ll.AddLast(new Entry { Key = key, Value = value });
            arr[key] = ll;
        }
    }

    class Entry
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
