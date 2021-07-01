using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

/*public class TimerScript : MonoBehaviour
{
    GetComponent<TimeSelectScript>();
    public float time = TimeSelectScript.timerValue;
    public Text timeText;
    //TimeSelectScript
    //timerValue

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TimeSelectScript>();

        time = TimeSelectScript.timerValue;
        print(time);
    }



    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = 0;
        }

        DisplayTime(time);
        
    }

    public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}*/
