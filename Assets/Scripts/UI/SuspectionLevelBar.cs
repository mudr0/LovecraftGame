using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuspectionLevelBar : Bar
{
    [SerializeField] private Neighbor _neighor;

    private void OnEnable()
    {
        _neighor.SuspectionLevelChanged += OnValueChanged;
    }

    private void OnDisable()
    {
        _neighor.SuspectionLevelChanged -= OnValueChanged;

    }
}
