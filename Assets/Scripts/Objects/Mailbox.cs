using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mailbox : InteractableObject
{
    [SerializeField] private GameObject _newspaper;

    private void Start()
    {
        IsInteractable = true;
    }

    public override void OnInteraction()
    {
        _newspaper.SetActive(true);
    }
}
