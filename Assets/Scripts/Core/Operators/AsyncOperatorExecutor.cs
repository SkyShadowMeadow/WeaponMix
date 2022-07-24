using System.Collections;
using UnityEngine;

namespace Core.Operators
{
    public class AsyncOperatorExecutor
    {
        public IEnumerator Execute(params IAsyncOperation[] operations)
        {
            foreach (var operation in operations)
            {
                yield return operation.Load();
            }
        }
    }
}
