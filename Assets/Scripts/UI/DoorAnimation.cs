using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
public class DoorAnimation : MonoBehaviour
{
    private Animator _animator;
    private BoxCollider2D _collider;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _collider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _animator.Play("Opened");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _animator.Play("Closed");
    }
}
