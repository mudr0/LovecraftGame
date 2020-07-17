using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int Money { get; private set; }
    public bool IsHaveFood { get; private set; }

    [SerializeField] private GameObject _foodIcon;

    public event UnityAction<int> MoneyChanged;

    public void ChangeMoney(int money)
    {
        Money += money;
        MoneyChanged?.Invoke(Money);
    }

    public void TakeFood()
    {
        IsHaveFood = true;
        _foodIcon.SetActive(true);
    }

    public void GiveFood()
    {
        IsHaveFood = false;
        _foodIcon.SetActive(false);
    }

    public void SpendMoney(int value)
    {
        Money -= value * 20;
        MoneyChanged?.Invoke(Money);
    }
}
