using System;
using System.Collections.Generic;

namespace Core.EventSystem.Events
{
	public static class SingleEvent
	{
		private static Dictionary<string, List<Action>> _events = new();

		public static void Add(string key, Action action)
		{
			if (!_events.ContainsKey(key))
			{
				_events.Add(key, new List<Action>());
			}

			_events[key].Add(action);
		}

		public static void Remove(string key, Action action)
		{
			if (_events.TryGetValue(key, out var actions))
			{
				actions.Remove(action);
			}
		}

		public static void Invoke(string key)
		{
			if (_events.TryGetValue(key, out var actions))
			{
				for (int i = 0; i < actions.Count; i++)
				{
					actions[i]?.Invoke();
				}
			}
		}
	}
}