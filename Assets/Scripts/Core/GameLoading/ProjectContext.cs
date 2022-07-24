using UI;
using UnityEngine;

namespace Core.GameLoading
{
    public class ProjectContext : MonoBehaviour
    {
        [SerializeField] private LoadingScreen _loadingScreen;

        public static ProjectContext Instance;

        public void Init()
        {
            Instance = this;
            _loadingScreen.Init();
        }
    }
}
