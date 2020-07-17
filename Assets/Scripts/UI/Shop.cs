using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Button _buyButton;
    [SerializeField] private GameObject _newspaper;

    private Refrigerator _refrigerator;
    private Player _player;
    private Slider _slider;

    private void OnEnable()
    {
        _refrigerator = FindObjectOfType<Refrigerator>();
        _player = FindObjectOfType<Player>();
        _slider = GetComponentInChildren<Slider>();
        _slider.maxValue = _refrigerator.GetSpaceLeft();
    }

    private void Update()
    {
        _buyButton.interactable = true;
        _text.text = _slider.value.ToString();
        if (_player.Money < 20 * _slider.value)
            _buyButton.interactable = false;
    }


    public void Buy()
    {
        _refrigerator.AddFood((int)_slider.value);
        _player.SpendMoney((int)_slider.value);
        gameObject.SetActive(false);
        _newspaper.SetActive(false);
    }
}
