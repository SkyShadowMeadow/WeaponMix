using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class GradientBackground : MonoBehaviour
    {
        [SerializeField] private RawImage _rawImage;
        
        [SerializeField] private Color _leftUpColor;
        [SerializeField] private Color _rightUpColor;
        [SerializeField] private Color _rightDownColor;
        [SerializeField] private Color _leftDownColor;

        private Texture2D _texture;

        private void Start()
            =>ShowGradient();
        
        void Update()
        {
            #if UNITY_EDITOR
            _texture.SetPixel(0,0,_leftDownColor);
            _texture.SetPixel(0,1,_leftUpColor);
            _texture.SetPixel(1,0,_rightDownColor);
            _texture.SetPixel(1,1,_rightUpColor);
            _texture.Apply();
            #endif
        }
        private void ShowGradient()
        {
            GenerateTexture();
            _rawImage.texture = _texture;
        }

        private void GenerateTexture()
        {
            _texture = new Texture2D(2, 2, TextureFormat.ARGB32, false);
            _texture.SetPixel(0,0,_leftDownColor);
            _texture.SetPixel(0,1,_leftUpColor);
            _texture.SetPixel(1,0,_rightDownColor);
            _texture.SetPixel(1,1,_rightUpColor);
            _texture.wrapMode = TextureWrapMode.Clamp;
            _texture.Apply();
        }
    }
}
