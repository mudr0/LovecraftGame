using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{

    protected Player Player;
    protected bool IsInteractable = false;

    private float _interactionDistance = 1.2f;
    private SpriteRenderer _renderer;
    private Color32 _highlightColor = new Color32(247, 255, 102, 255);
    private Color _startColor;

    private void OnEnable()
    {
        _renderer = GetComponent<SpriteRenderer>();
        Player = FindObjectOfType<Player>();
        _startColor = _renderer.color;
    }

    private void Update()
    {
        _renderer.color = _startColor;
        if (Vector2.Distance(transform.position, Player.transform.position) <= _interactionDistance && IsInteractable)
        {
            _renderer.color = _highlightColor;
            if (Input.GetKeyUp(KeyCode.E))
                OnInteraction();
        }
    }

    public void SetInteraction(bool isInteractable)
    {
        IsInteractable = isInteractable;
    }

    public virtual void OnInteraction()
    {

    }
}
