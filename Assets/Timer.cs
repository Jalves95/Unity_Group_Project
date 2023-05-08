using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool fin;

    void Start()
    {
        startTime = Time.time;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Finished");
        fin = true;
    }

    void Update()
    {
        if (fin)
        {
            return;
        }
        float currentTime = Time.time - startTime;

        string minutes = ((int)currentTime / 60).ToString();
        string seconds = (currentTime % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
        
    }

    public void finish()
    {
        fin = true;
        timerText.color = Color.yellow;
    }
}
