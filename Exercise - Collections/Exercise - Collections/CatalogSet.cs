using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Collections
{
    public class CatalogSet<TId, TElement> : ICatalog<TId, TElement>
    {
        HashSet<TElement> hashSet = new HashSet<TElement>();

        public bool Add(TId id, TElement element)
        {
            if (hashSet.Contains(element))
            {
                Console.WriteLine(element + " already exists!");
                return false;
            }
            hashSet.Add(element);
            Console.WriteLine(element);
            return true;
        }

    }
}
