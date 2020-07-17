using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _tempPanel;

    private Neighbor _neighbor;

    private void OnEnable()
    {
        _neighbor = FindObjectOfType<Neighbor>();
    }

    public void OpenShop()
    {
        if (_neighbor.IsHere==false)
        {
            _shopPanel.SetActive(true);
        }
        else if (_neighbor.IsHere)
        {
            _tempPanel.SetActive(true);
        }
    }
}
