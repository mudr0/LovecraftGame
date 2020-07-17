using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachedTransition : Transition
{
    [SerializeField] private Transform _destinationPoint;

    private void Update()
    {
        if (transform.position == _destinationPoint.position)
            NeedTransit = true;
    }
}
