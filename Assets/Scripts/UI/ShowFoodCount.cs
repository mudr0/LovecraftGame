using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFoodCount : MonoBehaviour
{
    [SerializeField] private GameObject _foodCount;

    private Player _player;

    private void OnEnable()
    {
        _player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        _foodCount.SetActive(false);
        if (Vector2.Distance(_player.transform.position, transform.position) < 2)
            _foodCount.SetActive(true);
    }
}
