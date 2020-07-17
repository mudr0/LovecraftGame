using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] private float _speed;

    private bool _isMovingRight = true;
    private float _minX = 250;
    private float _maxX = 900;

    private void Update()
    {
        if (_isMovingRight)
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
            if (transform.position.x >= _maxX)
                _isMovingRight = false;
        }
        else if(_isMovingRight==false)
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
            if (transform.position.x <= _minX)
                _isMovingRight = true;
        }
    }
}
