using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTransition : Transition
{
    [SerializeField] private ShootingMiniGame _game;

    private void Update()
    {
        if (_game.IsFinished)
        {
            NeedTransit = true;
            _game.Reset();
        } 
    }
}
