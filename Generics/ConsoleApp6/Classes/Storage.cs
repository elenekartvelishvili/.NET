using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    public class Storage<T> where T : IComparable<T>, IPrintable
    {

        private List<T> List = new List<T>();

        public void Add(T item)
        {

            List.Add(item);
        }

        public T GetMin()

        {
            if (List.Count == 0)
                throw new InvalidOperationException("List is empty");

            T current_min = List[0];

            foreach (T item in List)
            {

                if (current_min.CompareTo(item) >0) { current_min = item; }

            }

            return current_min;
        }
        public void Print()
        {
            foreach(T item in List) { item.Print(); }
           
        }
    }


}
