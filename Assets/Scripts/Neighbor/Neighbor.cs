using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Neighbor : InteractableObject
{
    [SerializeField] private ConversationMiniGame _miniGame;
    [SerializeField] private GameObject _endGamePanel;
    [SerializeField] private int _maxSuspectionLevel = 100;

    private int _currentSuspectionLevel;

    public event UnityAction<int,int> SuspectionLevelChanged;
    public bool IsHere { get; private set; }


    private void Start()
    {
        _currentSuspectionLevel = 0;
    }

    public void ChangeSuspectionLevel(int addSuspect)
    {
        _currentSuspectionLevel += addSuspect;
        if (_currentSuspectionLevel < 0)
            _currentSuspectionLevel = 0;
        SuspectionLevelChanged?.Invoke(_currentSuspectionLevel, _maxSuspectionLevel);
        if (_currentSuspectionLevel >= _maxSuspectionLevel)
        {
            _endGamePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void SetIsHere(bool isHere)
    {
        IsHere = isHere;
    }

    public override void OnInteraction()
    {
        _miniGame.gameObject.SetActive(true);
    }
}
