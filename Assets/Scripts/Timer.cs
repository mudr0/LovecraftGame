using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{

    [SerializeField] private float _secondsInHour;
    [SerializeField] private GameObject _victoryPanel;

    private int _hoursPassed;
    private int _maxHoursInDay = 12;
    private float _elapsedTime;

    public int DaysPassed { get; private set; }
    public event UnityAction<int, int> TimeChanged;
    public event UnityAction DaysChanged;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _secondsInHour)
        {
            _elapsedTime = 0;
            _hoursPassed += 1;
            TimeChanged?.Invoke(_hoursPassed,_maxHoursInDay);
            CheckDayPass(0);
        }
        if (DaysPassed > 5)
        {
            _victoryPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void CheckDayPass(int bonusHours)
    {
        if (_hoursPassed > _maxHoursInDay)
        {
            _hoursPassed = 1 + bonusHours;
            DaysPassed += 1;
            TimeChanged?.Invoke(_hoursPassed, _maxHoursInDay);
            DaysChanged.Invoke();
        }
    }

    public void PassHours(int hours)
    {
        int sum = _hoursPassed + hours;
        int balance = sum - _maxHoursInDay;
        _hoursPassed += hours;
        CheckDayPass(balance - 1);
        TimeChanged?.Invoke(_hoursPassed, _maxHoursInDay);
    }
}
