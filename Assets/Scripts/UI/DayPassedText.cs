using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayPassedText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Timer _timer;

    private void OnEnable()
    {
        _timer.DaysChanged += OnDaysChanged;
    }

    private void OnDisable()
    {
        _timer.DaysChanged -= OnDaysChanged;
    }


    private void OnDaysChanged()
    {
        _text.text = "Дней прошло: " + _timer.DaysPassed;
    }
    
    
}
