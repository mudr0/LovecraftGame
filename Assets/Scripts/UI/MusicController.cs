using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource _music;

    public void OnClick()
    {
        if (_music.volume>0)
        {
            _music.volume = 0;
        }
        else if (_music.volume==0)
        {
            _music.volume += 0.215f;
        }
    }
}
