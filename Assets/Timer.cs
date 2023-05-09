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
    public GameObject player;

    void Start()
    {
        startTime = Time.time;
    }



    void Update()
    {
        if (player.transform.position.x < 40)
        {
            Debug.Log("Finished");
            fin = true;
        }
        if (fin)
        {
            finish();
            return;
        }
        float currentTime = Time.time - startTime;

        string minutes = ((int)currentTime / 60).ToString();
        string seconds = (currentTime % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;

    }

    public void finish()
    {
        timerText.color = Color.yellow;
    }
}
