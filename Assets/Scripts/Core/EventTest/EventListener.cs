using Core.EventSystem.EventManager;
using TMPro;
using UnityEngine;

namespace Core.EventTest
{
	public class EventListener : MonoBehaviour
	{
		private void Awake()
		{
			EventManager.Add<int>("AddNumberTest", ChangeText);
		}

		public void ChangeText(int i)
		{
			GetComponent<TextMeshProUGUI>().text = i.ToString();
		}
	}
}