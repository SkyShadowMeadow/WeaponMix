using System;
using System.Collections.Generic;
using Core.EventSystem.Events;

namespace Core.EventSystem.EventHandlers
{
	public static class GenericEventHandler
	{
		private static Dictionary<Type, BaseEvent> events = new();

		public static void Add<T>(string key, Action<T> action)
		{
			//     var type = typeof(T);
			//
			//     GenericEvent<T> event_ = null;
			//     if (!events.ContainsKey(type))
			//     {
			//         event_ = new GenericEvent<T>();
			//         events.Add(type, event_);
			//     }
			//     else
			//     {
			//         event_ = events[type] as GenericEvent<T>;
			//     }
			//     
			//     event_.Add(key, action);
			//     
			// }
			//
			// public static void Remove<T>(string key, Action<T> action)
			// {
			//     if (events.TryGetValue(typeof(T), out var baseEvent))
			//     {
			//         var tEvent =  baseEvent as GenericEvent<T>;
			//         tEvent.Remove(key, action);
			//     }
			// }
			//
			// public static void Invoke<T>(string key, T arg)
			// {
			//     if (events.TryGetValue(typeof(T), out var baseEvent))
			//     {
			//         var tEvent =  baseEvent as GenericEvent<T>;
			//         tEvent.Invoke(key,arg);
			//     }
		}
	}
}