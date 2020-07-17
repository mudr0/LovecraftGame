using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Refrigerator : InteractableObject
{
    [SerializeField] private int _maxSize;

    public int Food { get; private set; }
    public event UnityAction<int> FoodCountChanged;

    private void Start()
    {
        IsInteractable = true;
        AddFood(5);
    }

    public void AddFood(int value)
    {
        Food += 1 * value;
        FoodCountChanged?.Invoke(Food);
    }

    public void RemoveFood()
    {
        if (Food > 0)
        {
            Food -= 1;
            FoodCountChanged?.Invoke(Food);
        }
    }

    public int GetSpaceLeft()
    {
        int spaceLeft = _maxSize - Food;
        return spaceLeft;
    }

    public override void OnInteraction()
    {
        if (!Player.IsHaveFood && Food > 0)
        {
            RemoveFood();
            Player.TakeFood();
        }
    }
}
