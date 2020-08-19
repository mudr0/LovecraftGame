using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DisappearingState : State
{
    [SerializeField] private Gun _gun;

    private Animator _animator;

    private void OnEnable()
    {
        _gun.SetInteraction(false);
        _animator = GetComponent<Animator>();
        _animator.Play("Fading");
    }
}
