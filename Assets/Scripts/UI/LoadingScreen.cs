using System;
using System.Collections;
using Core.Operators;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class LoadingScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _loadingScreenCanvasGroup;
        [SerializeField] private Image _loadingFilling;

        private AsyncOperatorExecutor _asyncOperatorExecutor;

        public void Init()
        {
            _asyncOperatorExecutor = new AsyncOperatorExecutor();

            _loadingScreenCanvasGroup.alpha = 0;
            _loadingScreenCanvasGroup.interactable = false;
            _loadingScreenCanvasGroup.blocksRaycasts = false;
            _loadingFilling.fillAmount = 0;
        }
        
        public void Execute(params IAsyncOperation[] asyncOperations)
            => StartCoroutine(Executing(asyncOperations));

        private IEnumerator Executing(IAsyncOperation[] asyncOperations)
        {
            _loadingScreenCanvasGroup.alpha = 1;
            _loadingScreenCanvasGroup.blocksRaycasts = true;
            _loadingFilling.fillAmount = 0;

            int completedOperations = 0;

            foreach (var asyncOperation in asyncOperations)
            {
                yield return _asyncOperatorExecutor.Execute(asyncOperation);
                completedOperations++;
                _loadingFilling.fillAmount = (float)completedOperations/asyncOperations.Length;
                
            }
            
            _loadingScreenCanvasGroup.alpha = 0;
            _loadingScreenCanvasGroup.blocksRaycasts = false;
        }
    }
}