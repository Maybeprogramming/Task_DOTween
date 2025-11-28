using DG.Tweening;
using UnityEngine;

public class RotateProvider : MonoBehaviour
{
    [SerializeField] private float _durationTime;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private Vector3 _rotateDirection;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;

    private void Start()
    {
        transform.DORotate(_rotateDirection, _durationTime, _rotateMode).SetLoops(_repeat, _loopType).SetDelay(_delayTime);
    }
}