using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPanel : MonoBehaviour
{
    [SerializeField] private float _duration;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _duration)
        {
            _elapsedTime = 0;
            gameObject.SetActive(false);
        }
    }
}
