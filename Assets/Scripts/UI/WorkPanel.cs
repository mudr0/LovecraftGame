using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkPanel : MonoBehaviour
{
    [SerializeField] private GameObject _paper;
    [SerializeField] private GameObject _cantGoScreen;
    [SerializeField] private TMP_Text _conditions;
    [SerializeField] private int _hoursWillPass;
    [SerializeField] private int _moneyWillGet;
    [SerializeField] private int _supectionWillGet;
    [SerializeField] private int _monsterWillStarve;

    private Neighbor _neighbor;
    private Monster _monster;
    private Player _player;
    private Timer _timer;

    private void Start()
    {
        _neighbor = FindObjectOfType<Neighbor>();
        _monster = FindObjectOfType<Monster>();
        _player = FindObjectOfType<Player>();
        _timer = FindObjectOfType<Timer>();
        _conditions.text = "Плата: " + _moneyWillGet + "$. Время работы: " + _hoursWillPass + " ч.";
    }

    public void Work()
    {
        if (_neighbor.IsHere)
        {
            _cantGoScreen.SetActive(true);

        }
        else if (_neighbor.IsHere == false)
        {
            _timer.PassHours(_hoursWillPass);
            _player.ChangeMoney(_moneyWillGet);
            _player.gameObject.GetComponent<PlayerMover>().ComeBack();
            _monster.Starve(_monsterWillStarve);
            _neighbor.ChangeSuspectionLevel(_supectionWillGet);
            _paper.SetActive(false);
        }
    }
}
