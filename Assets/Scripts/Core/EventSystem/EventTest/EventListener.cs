using TMPro;
using UnityEngine;

namespace Core.EventSystem.EventTest
{
	public class EventListener : MonoBehaviour
	{
		private void Awake()
		{
			EventManager.EventManager.Add<int>(TestEnum.AddNumberTest, ChangeText);
		}

		public void ChangeText(int i)
		{
			GetComponent<TextMeshProUGUI>().text = i.ToString();
		}
	}
}