using System;
using System.Collections.Generic;
using Core.EventSystem.Dispose;

namespace Core.EventSystem.Events
{
	public static class GenericEvent<T>
	{
		private static Dictionary<string, List<Action<T>>> _events = new();

		public static DisposeContainer Add(string key, Action<T> action)
		{
			if (!_events.ContainsKey(key))
			{
				_events.Add(key, new List<Action<T>>());
			}

			_events[key].Add(action);
			return new DisposeContainer(() => Remove(key, action));
		}

		public static void Remove(string name, Action<T> action)
		{
			if (_events.TryGetValue(name, out var actions))
			{
				actions.Remove(action);
			}
		}

		public static void Invoke(string name, T value)
		{
			if (_events.TryGetValue(name, out var actions))
			{
				for (int i = 0; i < actions.Count; i++)
				{
					actions[i]?.Invoke(value);
				}
			}
		}
	}
}