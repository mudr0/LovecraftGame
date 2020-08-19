using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class FoodCount : MonoBehaviour
{
    [SerializeField] private Refrigerator _refrigerator;
    [SerializeField] private Animator _animator;

    private TMP_Text _text;

    private void OnEnable()
    {
        _text = GetComponent<TMP_Text>();
        _text.text = _refrigerator.Food.ToString();
        _refrigerator.FoodCountChanged += OnFoodCountChanged;
    }

    private void OnDisable()
    {
        _refrigerator.FoodCountChanged -= OnFoodCountChanged;
    }

    private void OnFoodCountChanged(int count)
    {
        _text.text = count.ToString();
    }

    public void StartFlashing()
    {
        _animator.Play("Flashing");
    }

    public void StopFlashing()
    {

    }
}
