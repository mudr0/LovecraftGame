using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBar : CircleBar
{
    [SerializeField] private Timer _timer;

    private void OnEnable()
    {
        _timer.TimeChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _timer.TimeChanged -= OnValueChanged;
    }
}
