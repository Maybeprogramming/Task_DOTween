using DG.Tweening;
using UnityEngine;

public class ScaleProvider : MonoBehaviour
{
    [SerializeField] private float _durationTime;
    [SerializeField] private Vector3 _scaleVector;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;

    private void Start()
    {
        transform.DOScale(_scaleVector, _durationTime).SetLoops(_repeat, _loopType).SetDelay(_delayTime);
    }
}