using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Collections
{

    public class CatalogList<TElement> where TElement : IIdentifiable
    {
        IList<TElement> list = new List<TElement>();

        public bool Add(TElement element)
        {
            if (list.Contains(element))
            {
                Console.WriteLine(element.Id + " already exists!");
                return false;
            }
            list.Add(element);
            Console.WriteLine(element.Id + " added to list"); 
            return true;
        }

        public TElement Find(int id)
        {
            foreach (TElement k in list)
            {
                if (k.Id == id)
                {
                    Console.WriteLine("Student with id: " + k.Id + " was found");
                    return k;
                }
            }
            Console.WriteLine("Student was not found [default]");
            return default(TElement);
        }

        public IList<TElement> GetAll()
        {
            return list;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CatalogList content: [");
            foreach (var VARIABLE in list)
            {
                sb.Append(VARIABLE);
                sb.Append(", ");
            }
            sb.Append("]");
            return sb.ToString();
        }

        public int Count()
        {
            return list.Count;
        }
    }
}
