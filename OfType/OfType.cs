using System.Collections;

namespace OfType
{
    public class TypeFiftyNine : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            return enumerable.OfType<T>();
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return enumerable.OfType<TOutput>();
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            return derivedItems.OfType<TBase>();
        }
    }
}
