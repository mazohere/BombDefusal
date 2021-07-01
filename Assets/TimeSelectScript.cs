using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class TimeSelectScript : MonoBehaviour
{
    public Button easy;
    public Button medium;
    public Button hard;
    public Button pain;
    public Button TimeConfirm;
    public static float timerValue;
    public static bool timeConfirmationBool = false;

    public void OnButtonClick(string time)
    {
        if (time == "3:00")
        {
            timerValue = 180f;
            easy.GetComponentInChildren<Image>().color = Color.red;
            medium.GetComponentInChildren<Image>().color = Color.white;
            hard.GetComponentInChildren<Image>().color = Color.white;
            pain.GetComponentInChildren<Image>().color = Color.white;
            easy.interactable = false;
            medium.interactable = true;
            hard.interactable = true;
            pain.interactable = true;
        }
        else if (time == "1:00")
        {
            timerValue = 60f;
            easy.GetComponentInChildren<Image>().color = Color.white;
            medium.GetComponentInChildren<Image>().color = Color.red;
            hard.GetComponentInChildren<Image>().color = Color.white;
            pain.GetComponentInChildren<Image>().color = Color.white;
            easy.interactable = true;
            medium.interactable = false;
            hard.interactable = true;
            pain.interactable = true;
        }
        else if (time == "0:45")
        {
            timerValue = 45f;
            easy.GetComponentInChildren<Image>().color = Color.white;
            medium.GetComponentInChildren<Image>().color = Color.white;
            hard.GetComponentInChildren<Image>().color = Color.red;
            pain.GetComponentInChildren<Image>().color = Color.white;
            easy.interactable = true;
            medium.interactable = true;
            hard.interactable = false;
            pain.interactable = true;
        }
        else if (time == "0:30")
        {
            timerValue = 30f;
            easy.GetComponentInChildren<Image>().color = Color.white;
            medium.GetComponentInChildren<Image>().color = Color.white;
            hard.GetComponentInChildren<Image>().color = Color.white;
            pain.GetComponentInChildren<Image>().color = Color.red;
            easy.interactable = true;
            medium.interactable = true;
            hard.interactable = true;
            pain.interactable = false;
        }
        else if (time == "TimeConfirm")
        {
            if (timerValue == 0)
            {
                print("You must select time before proceeding");
            }
            else
            {
                easy.interactable = false;
                medium.interactable = false;
                hard.interactable = false;
                pain.interactable = false;
                TimeConfirm.interactable = false;

                timeConfirmationBool = true;
            }
            

        }

        print(timerValue.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
