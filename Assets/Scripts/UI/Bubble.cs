using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private Neighbor _neighbor;

    private bool _isCorrect = false;

    public void ChangeSuspectionLevel()
    {
        if (_isCorrect)
            _neighbor.ChangeSuspectionLevel(-4);
        else if (!_isCorrect)
            _neighbor.ChangeSuspectionLevel(10);
    }

    public void SetCorrect(bool isCorrect)
    {
        _isCorrect = isCorrect;
    }
}
