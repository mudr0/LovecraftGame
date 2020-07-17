using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMonsterState : MonoBehaviour
{
    [SerializeField] private Monster _monster;
    [SerializeField] private int _hunger;
    [SerializeField] private float _delay;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _delay)
        {
            _elapsedTime = 0;
            _monster.Starve(_hunger);
        }
    }
}
