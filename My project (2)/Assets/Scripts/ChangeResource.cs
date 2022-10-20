using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeResource : MonoBehaviour
{
    [SerializeField] private ResourceTypes resourceType;
    [SerializeField] private Button button;
    [SerializeField] TextMeshProUGUI timerText;

    private float _enrichmentTime;
    private float _decayTime;
    private float _timer;
    private bool _isEnrichment;
    void Start()
    {
        gameObject.GetComponent<Image>().sprite = SingletonDisplayService.Instance.GetEnrichmentSprite(resourceType);
        _enrichmentTime = SingletonDataService.Instance.GetEnchrichmentTime(resourceType);
        _decayTime = SingletonDataService.Instance.GetDecayTime(resourceType);
        _timer = 0;
        button.interactable = false;
        _isEnrichment = true;
        button.onClick.AddListener(EnrichmentTime);
    }

    private void Update()
    {
        if (_isEnrichment)
        {
            if(_timer >= _enrichmentTime)
            {
                DecayTime();
                _timer = 0;
            }
            else
            {
                _timer += Time.deltaTime;
            }
        }
        else
        {
            if (_timer >= _decayTime)
            {
                Lose();
                _timer = 0;
            }
            else
            {
                _timer += Time.deltaTime;
            }
        }
        timerText.text = $"{System.Math.Floor(_timer)}";
    }

    private void EnrichmentTime()
    {
        button.interactable = false;
        _timer = 0;
        gameObject.GetComponent<Image>().sprite = SingletonDisplayService.Instance.GetEnrichmentSprite(resourceType);
        _isEnrichment = true;
    }

    private void DecayTime()
    {
        button.interactable = true;
        gameObject.GetComponent<Image>().sprite = SingletonDisplayService.Instance.GetDecaySprite(resourceType);
        _isEnrichment = false;
    }
    private void Lose()
    {
        Debug.Log("Lose");
    }
}
