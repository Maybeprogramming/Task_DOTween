using DG.Tweening;
using UnityEngine;

public class ColorProvider : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _endColor;
    [SerializeField] private float _durationTime;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;

    private void Start()
    {
        _meshRenderer.material.DOColor(_endColor, _durationTime).SetLoops(_repeat, _loopType).SetDelay(_delayTime);
    }
}