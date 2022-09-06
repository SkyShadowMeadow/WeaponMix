using System;

namespace Core.EventSystem.Dispose
{
	public class DisposeContainer
	{
		private Action _action;

		public DisposeContainer(Action action)
		{
			_action = action;
		}

		public void Invoke()
		{
			_action?.Invoke();
			_action = null;
		}
	}
}
