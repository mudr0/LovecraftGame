using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationMiniGame : MonoBehaviour
{
    [SerializeField] private Image[] _bubbles;
    [SerializeField] private float _delay;
    [SerializeField] private float _duration;

    private int _correctBubbleIndex;
    private int _lastBubbleIndex;
    private float _elapsedTimeUntilDelay;
    private float _elapsedTimeUntilEnd;

    public bool IsFinished { get; private set; }

    private void OnEnable()
    {
        _elapsedTimeUntilEnd = 0;
        _correctBubbleIndex = 0;
        _elapsedTimeUntilDelay = 0;
        foreach (var bubble in _bubbles)
        {
            bubble.color = new Color32(255, 255, 255, 255);
        }
    }

    private void Update()
    {
        _elapsedTimeUntilEnd += Time.deltaTime;
        _elapsedTimeUntilDelay += Time.deltaTime;
        if (_elapsedTimeUntilDelay >= _delay)
        {
            _correctBubbleIndex = Random.Range(0, _bubbles.Length);
            if (_correctBubbleIndex == _lastBubbleIndex)
                _correctBubbleIndex += 1;
            if (_correctBubbleIndex >= _bubbles.Length)
                _correctBubbleIndex = 0;
            foreach (var bubble in _bubbles)
            {
                bubble.color = new Color32(255, 255, 255, 255);
                bubble.GetComponent<Bubble>().SetCorrect(false);
            }
            _elapsedTimeUntilDelay = 0;
            for (int i = 0; i < _bubbles.Length; i++)
            {
                _bubbles[_correctBubbleIndex].color = new Color32(149, 246, 117, 255);
                _bubbles[_correctBubbleIndex].GetComponent<Bubble>().SetCorrect(true);
            }
            _lastBubbleIndex = _correctBubbleIndex;
        }
        if (_elapsedTimeUntilEnd >= _duration)
            gameObject.SetActive(false);
    }

    public void Reset()
    {
        IsFinished = false;
    }

    private void OnDisable()
    {
        IsFinished = true;
    }
}
