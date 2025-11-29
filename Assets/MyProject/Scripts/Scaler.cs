using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _durationTime;
    [SerializeField] private Vector3 _scaleVector;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;

    private void Start()
    {
        DoScale(_scaleVector);
    }

    private void DoScale(Vector3 scaleVector)
    {
        transform.DOScale(scaleVector, _durationTime).SetLoops(_repeat, _loopType).SetDelay(_delayTime);
    }
}