using DG.Tweening;
using System;
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

        Sequence sequence = CreateSequenceAnimation();
        sequence.Play();
    }

    private Sequence CreateSequenceAnimation()
    {
        Sequence sequence = DOTween.Sequence();

        return sequence.Append(ReplaceText(_textToReplace))
            .Append(AddText(_textToAdd))
            .Append(ToScrambleText(_textToScramble))
            .Join(ApplyEndColorToText(_endColor))
            .SetLoops(_repeat, _loopType)
            .SetDelay(_delayTime)
            .Pause();
    }

    private Tween ApplyEndColorToText(Color endColor)
    {
        return _textLabel.DOColor(endColor, _durationTime);
    }

    private Tween ToScrambleText(string text)
    {
        return _textLabel.DOText(text, _durationTime, _reachTextEnabled, ScrambleMode.All);
    }

    private Tween AddText(string text)
    {
        return _textLabel.DOText(text, _durationTime, _reachTextEnabled, ScrambleMode.None).SetRelative();
    }

    private Tween ReplaceText(string text)
    {
        return _textLabel.DOText(text, _durationTime, _reachTextEnabled, ScrambleMode.None);
    }
}