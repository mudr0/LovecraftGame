using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AppearanceState : State
{
    [SerializeField] private float _timeUnitlFoodRemove;
    [SerializeField] private Refrigerator _refrigerator;
    [SerializeField] private FoodCount _foodCount;
    [SerializeField] private Gun _gun;

    private Animator _animator;
    private float _elapsedTime;

    private void OnEnable()
    {
        _gun.SetInteraction(true);
        _animator = GetComponent<Animator>();
        _animator.Play("Appearance");
        _foodCount.StartFlashing();
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _timeUnitlFoodRemove)
        {
            _elapsedTime = 0;
            _refrigerator.RemoveFood();
        }
    }
}
