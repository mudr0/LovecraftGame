using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject _menu;

    private PlayerMover _mover;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        _animator.SetBool("Walking", false);
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool("Walking", true);
            _mover.MoveRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool("Walking", true);
            _mover.MoveLeft();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _menu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
