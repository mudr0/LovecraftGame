using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Monster : InteractableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private GameObject _endGamePanel;

    private int _currentHealth;

    public event UnityAction<int, int> HealthChanged;

    private void Start()
    {
        SetInteraction(true);
        _currentHealth = _maxHealth;
    }

    public void Starve(int hunger)
    {
        _currentHealth -= hunger;
        HealthChanged?.Invoke(_currentHealth, _maxHealth);
        if (_currentHealth <= 0)
        {
            _endGamePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void EatFood()
    {
        _currentHealth += 25;
        if (_currentHealth > 100)
            _currentHealth = 100;
    }

    public override void OnInteraction()
    {
        if (Player.IsHaveFood)
        {
            Player.GiveFood();
            EatFood();
            HealthChanged?.Invoke(_currentHealth,_maxHealth);
        }
    }
}
