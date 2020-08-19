using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _point;

    private SpriteRenderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void  MoveRight()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);
        _renderer.flipX = false;
    }

    public void MoveLeft()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        _renderer.flipX = true;
    }

    public void ComeBack()
    {
        _renderer.flipX = false;
        transform.position = _point.position;
    }
}
