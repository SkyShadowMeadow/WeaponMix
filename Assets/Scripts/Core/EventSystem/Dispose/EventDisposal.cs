using System.Collections.Generic;

namespace Core.EventSystem.Dispose
{
	public class EventDisposal
	{
		private List<DisposeContainer> _disposeActions = new();

		public void Add(DisposeContainer disposeAction)
		{
			_disposeActions.Add(disposeAction);
		}

		public void Dispose()
		{
			while (_disposeActions.Count > 0)
			{
				var disposeAction = _disposeActions[0];
				_disposeActions.Remove(disposeAction);
				disposeAction?.Invoke();
			}
		}
	}
}