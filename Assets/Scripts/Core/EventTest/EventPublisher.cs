using Core.EventSystem.EventManager;
using UnityEngine;

namespace Core.EventTest
{
    public class EventPublisher : MonoBehaviour
    {
        
        void Start()
        {
            EventManager.Invoke("AddNumberTest", 5);
        }
    }
}
