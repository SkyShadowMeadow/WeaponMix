using System;
using Core.EventSystem.Dispose;
using Core.EventSystem.Events;

namespace Core.EventSystem.EventManager
{
	public static class EventManager
	{
		public static DisposeContainer Add<T>(Enum key, Action<T> action)
			=> GenericEvent<T>.Add(key.ToString(), action);
		
		public static DisposeContainer Add(Enum key, Action action)
			=> SingleEvent.Add(key.ToString(), action);

		public static void Invoke<T>(Enum key, T value)
			=> GenericEvent<T>.Invoke(key.ToString(), value);
		
		public static void Invoke(Enum key)
			=> SingleEvent.Invoke(key.ToString());
	}
}