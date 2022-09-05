using System;
using System.Collections.Generic;

namespace Core.EventSystem.Events
{
	public static class GenericEvent<T> 
	{
		private static Dictionary<string, List<Action<T>>> _events = new();

		public static void Add(string name, Action<T> action)
		{
			if (!_events.ContainsKey(name))
			{
				_events.Add(name, new List<Action<T>>());
			}

			_events[name].Add(action);
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