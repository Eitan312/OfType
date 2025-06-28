using System.Collections;
using System.Linq;

namespace OfType
{
    public class TypeFiftyNine : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            return FilterItems<T>(enumerable);
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return FilterItems<TOutput>(enumerable);
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            return derivedItems.Cast<TBase>();
        }

        public IEnumerable<TOutPut> FilterItems<TOutPut>(IEnumerable items)
        {
            IEnumerator enumerator = items.GetEnumerator();
            List<TOutPut> filteredItems = new List<TOutPut>();

            while(enumerator.MoveNext())
            {
                if(enumerator.Current is TOutPut)
                {
                    filteredItems.Add((TOutPut)enumerator.Current);
                }
            }

            return filteredItems;
        }
    }
}
