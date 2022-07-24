using System.Collections;

namespace Core.Operators
{
    public interface IAsyncOperation
    {
        public IEnumerator Load();
    }
}