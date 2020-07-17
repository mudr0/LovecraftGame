using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePassedTransition : Transition
{
    [SerializeField] private float _minTime;
    [SerializeField] private float _maxTime;
    private float _elapsedTime;
    private float _delay;

    private void OnEnable()
    {
        SetRandomTime();
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _delay)
        {
            _elapsedTime = 0;
            NeedTransit = true;
        }
    }

    private float SetRandomTime()
    {
        _delay = Random.Range(_minTime, _maxTime);

        return _delay;
    }
}
