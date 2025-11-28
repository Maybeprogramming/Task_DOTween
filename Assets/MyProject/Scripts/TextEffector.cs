using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextEffector : MonoBehaviour
{
    [SerializeField] private Text _textLabel;
    [SerializeField] private string _textDefault;
    [SerializeField] private string _textToReplace;
    [SerializeField] private string _textToAdd;
    [SerializeField] private string _textToScramble;
    [SerializeField] private bool _reachTextEnabled;
    [SerializeField] private float _durationTime;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private float _delayTime;
    [SerializeField] private Color _endColor;

    private void Start()
    {
        _textLabel.text = _textDefault;

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_textLabel.DOText(_textToReplace, _durationTime, _reachTextEnabled, ScrambleMode.None))
            .Append(_textLabel.DOText(_textToAdd, _durationTime, _reachTextEnabled, ScrambleMode.None).SetRelative())         
            .Append(_textLabel.DOText(_textToScramble, _durationTime, _reachTextEnabled, ScrambleMode.All))
            .Append(_textLabel.DOColor(_endColor, _durationTime))           
            .SetLoops(_repeat, _loopType)
            .SetDelay(_delayTime);       
    }
}