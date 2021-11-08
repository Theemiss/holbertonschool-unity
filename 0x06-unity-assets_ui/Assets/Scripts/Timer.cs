using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Timer : MonoBehaviour
{
    public Text TimerText;
    private DateTime StartTimer;
    private float time = 0f;
    private bool finish = false;
    private bool run = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void timerchecker(bool a)
    {
        if (a == true)
        {
            run = true;
        }
        else
        {
            run = false;
            finish = true;
        }
    }
     void setTime()
    {
        float min = time % 60;
        float sec = (time/60) % 60;
        float h = (time / 3600);
        TimerText.text = $"{h,0:00}:{min,0:00}:{sec,0:00}";

    }
    // Update is called once per frame
    void Update()
    {
        if (run && !finish)
        {
            time += Time.deltaTime;
        }
        setTime();
    }
}
