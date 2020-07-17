using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : InteractableObject
{
    [SerializeField] private GameObject _shootingMiniGame;

    private void Start()
    {
        SetInteraction(true);
    }

    public override void OnInteraction()
    {
        _shootingMiniGame.SetActive(true);
    }
}
