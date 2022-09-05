using System;
using Core.EventSystem.Events;

namespace Core.EventSystem.EventManager
{
	public static class EventManager
	{
		public static void Add<T>(string key, Action<T> action)
			=> GenericEvent<T>.Add(key, action);

		public static void Invoke<T>(string key, T value)
			=> GenericEvent<T>.Invoke(key, value);
	}
}