using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalTimer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI globalTimerText;

    private float timer;
    private bool isOn;
    
    void Start()
    {
        timer = 0;
        isOn = false;
    }

    void Update()
    {
        if (isOn)
        {
            timer += Time.deltaTime;
            globalTimerText.text = $"{System.Math.Floor(timer)}";
        }
    }

    public void StartTimer() => isOn = true;
    public void StopTimer() => isOn = false;
}
