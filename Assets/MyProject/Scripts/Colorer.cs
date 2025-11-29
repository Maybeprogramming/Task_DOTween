using DG.Tweening;
using UnityEngine;

public class Colorer : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _endColor;
    [SerializeField] private float _durationTime;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;

    private void Start()
    {
        ApplyEndColor(_endColor);
    }

    private void ApplyEndColor(Color endColor)
    {
        _meshRenderer.material.DOColor(endColor, _durationTime).SetLoops(_repeat, _loopType).SetDelay(_delayTime);
    }
}