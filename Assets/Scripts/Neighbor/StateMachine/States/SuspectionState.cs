using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Neighbor))]
public class SuspectionState : State
{
    [SerializeField] private float _delay;

    private Animator _animator;
    private Neighbor _neighbor;
    private float _elapsedTime;

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();
        _neighbor = GetComponent<Neighbor>();
        _neighbor.SetInteraction(true);
        _animator.SetBool("Standing", true);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _delay)
        {
            _elapsedTime = 0;
            _neighbor.ChangeSuspectionLevel(2);
        }
    }

    private void OnDisable()
    {
        _neighbor.SetInteraction(false);
    }
}
