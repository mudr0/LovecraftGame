using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterHealthBar : Bar
{
    [SerializeField] private Monster _monster;

    private void OnEnable()
    {
        _monster.HealthChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _monster.HealthChanged -= OnValueChanged;
    }
}
