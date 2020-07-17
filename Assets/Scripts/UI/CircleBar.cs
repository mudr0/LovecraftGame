using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleBar : MonoBehaviour
{
    [SerializeField] protected Image Image;

    public void OnValueChanged(int value, int maxValue)
    {
        Image.fillAmount = (float)value / maxValue;
    }
}
