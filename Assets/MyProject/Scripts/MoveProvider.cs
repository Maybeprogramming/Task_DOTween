using DG.Tweening;
using UnityEngine;

public class MoveProvider : MonoBehaviour
{
    [SerializeField] private float _durationTime;
    [SerializeField] private bool _snapping;
    [SerializeField] private Transform _targetToMove;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;

    private void Start()
    {
        transform.DOMove(_targetToMove.position, _durationTime, _snapping).SetLoops(_repeat,_loopType).SetDelay(_delayTime);
    }
}