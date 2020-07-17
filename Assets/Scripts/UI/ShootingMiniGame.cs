using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingMiniGame : MonoBehaviour
{
    [SerializeField] private Aim _aim;

    private bool _aimIsReady;

    public bool IsFinished { get; private set; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _aimIsReady == true)
        {
            gameObject.SetActive(false);
            IsFinished = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Aim>(out Aim aim))
        {
            _aimIsReady = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Aim>(out Aim aim))
        {
            _aimIsReady = false;
        }
    }

    public void Reset()
    {
        IsFinished = false;
    }

}
