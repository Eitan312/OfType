using System.Collections;
using System.Linq;

namespace OfType
{
    public class TypeFiftyNine : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            List<T> filteredItems = new List<T>();
            IEnumerator items = enumerable.GetEnumerator();
            while(items.MoveNext())
            {
                if(items.Current is T)
                {
                    filteredItems.Add((T)items.Current);
                }
            }

            return (IEnumerable<T>)filteredItems;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            List<TOutput> filteredItems = new List<TOutput>();
            IEnumerator items = enumerable.GetEnumerator();
            while (items.MoveNext())
            {
                if (items.Current is TOutput)
                {
                    filteredItems.Add((TOutput)items.Current);
                }
            }

            return (IEnumerable<TOutput>)filteredItems;
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            List<TBase> filteredItems = new List<TBase>();
            IEnumerator items = derivedItems.GetEnumerator();
            while (items.MoveNext())
            {
                if (items.Current is TBase)
                {
                    filteredItems.Add((TBase)items.Current);
                }
            }

            return (IEnumerable<TBase>)filteredItems;
        }
    }
}
