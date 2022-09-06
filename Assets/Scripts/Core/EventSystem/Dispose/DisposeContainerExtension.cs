using UnityEngine;

namespace Core.EventSystem.Dispose
{
    public static class DisposeContainerExtension 
    {
        public static DisposeContainer AddTo(this DisposeContainer container, EventDisposal eventDisposal)
        {
            eventDisposal.Add(container);
            return container;
        }
    }
}
