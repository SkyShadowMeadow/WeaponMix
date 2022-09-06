using UnityEngine;

namespace Core.EventSystem.EventTest
{
	public class EventPublisher : MonoBehaviour
	{
		void Start()
		{
			EventManager.EventManager.Invoke(TestEnum.AddNumberTest, 5);
		}
	}
}