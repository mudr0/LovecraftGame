﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    [SerializeField] private Transform _destinationPoint;
    [SerializeField] private float _speed;

    private Animator _animator;
    private Neighbor _neighbor;
    private SpriteRenderer _renderer;

    private void OnEnable()
    {
        _animator = GetComponent<Animator>();
        _neighbor = GetComponent<Neighbor>();
        _renderer = GetComponent<SpriteRenderer>();
        _neighbor.SetIsHere(true);
        _renderer.flipX = false;
        _animator.SetBool("Standing", false);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _destinationPoint.position, _speed * Time.deltaTime);
    }
}
