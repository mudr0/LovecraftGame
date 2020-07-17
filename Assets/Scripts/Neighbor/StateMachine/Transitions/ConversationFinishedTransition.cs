using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationFinishedTransition : Transition
{
    [SerializeField] private ConversationMiniGame _game;

    private void Update()
    {
        if (_game.IsFinished)
        {
            NeedTransit = true;
            _game.Reset();
        }
    }
}
