using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTransition : Transition
{
    [SerializeField] private float _timeUntilNextState;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _timeUntilNextState)
        {
            _elapsedTime = 0;
            NeedTransit = true;
        }
    }
}
