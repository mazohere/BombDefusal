using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public bool condition1;
    public bool condition2;
    public List<GameObject> menuItems;
    public float time;
    public Text timeText;
    public static bool gameStartBool = false;
    public List<GameObject> moduals;
    public GameObject Timer;
    public List<GameObject> modual0Picks;
    public List<GameObject> modual1Picks;
    public List<GameObject> modual2Picks;
    public List<GameObject> modual3Picks;

    public List<GameObject> MultiChoiceQuestionComponents;
    public List<GameObject> TypingQuestionComponents;
    public List<GameObject> ButtonSelectQuestionComponents;

    public List<GameObject> MultiChoiceQuestionComponents1;
    public List<GameObject> TypingQuestionComponents1;
    public List<GameObject> ButtonSelectQuestionComponents1;

    public List<GameObject> MultiChoiceQuestionComponents2;
    public List<GameObject> TypingQuestionComponents2;
    public List<GameObject> ButtonSelectQuestionComponents2;

    public List<GameObject> MultiChoiceQuestionComponents3;
    public List<GameObject> TypingQuestionComponents3;
    public List<GameObject> ButtonSelectQuestionComponents3;

    public GameObject Light;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

    public static int modual0Pick;
    public static int modual1Pick;
    public static int modual2Pick;
    public static int modual3Pick;


    // Start is called before the first frame update
    void Start()
    {
        


    }

    public void GameStartFunction()
    {
        for (int i = 0; i < menuItems.Count; ++i)
        {
            menuItems[i].SetActive(false);
        }

        TimerStartFunction();

        for (int i = 0; i < moduals.Count; i++)
        {
            moduals[i].SetActive(true);
        }

        Light.SetActive(true);
        Light1.SetActive(true);
        Light2.SetActive(true);
        Light3.SetActive(true);

        modual0Pick = 2;
        modual1Pick = 2;
        modual2Pick = Random.Range(0, 3);
        modual3Pick = Random.Range(0, 3);
        print(modual0Pick);
        print(modual1Pick);
        print(modual2Pick);
        print(modual3Pick);

        if (modual0Pick == 0)
        {
            modual0Picks[0].SetActive(true);

            for (int i = 0; i < MultiChoiceQuestionComponents.Count; i++)
            {
                MultiChoiceQuestionComponents[i].SetActive(true);
            }
        }
        else if (modual0Pick == 1)
        {
            modual0Picks[1].SetActive(true);

            for (int i = 0; i < TypingQuestionComponents.Count; i++)
            {
                TypingQuestionComponents[i].SetActive(true);
            }
        }
        else if (modual0Pick == 2)
        {
            modual0Picks[2].SetActive(true);

            for (int i = 0; i < ButtonSelectQuestionComponents.Count; i++)
            {
                ButtonSelectQuestionComponents[i].SetActive(true);
            }
        }

        if (modual1Pick == 0)
        {
            modual1Picks[0].SetActive(true);

            for (int i = 0; i < MultiChoiceQuestionComponents1.Count; i++)
            {
                MultiChoiceQuestionComponents1[i].SetActive(true);
            }
        }
        else if (modual1Pick == 1)
        {
            modual1Picks[1].SetActive(true);

            for (int i = 0; i < TypingQuestionComponents1.Count; i++)
            {
                TypingQuestionComponents1[i].SetActive(true);
            }
        }
        else if (modual1Pick == 2)
        {
            modual1Picks[2].SetActive(true);

            for (int i = 0; i < ButtonSelectQuestionComponents1.Count; i++)
            {
                ButtonSelectQuestionComponents1[i].SetActive(true);
            }
        }

        if (modual2Pick == 0)
        {
            modual2Picks[0].SetActive(true);

            for (int i = 0; i < MultiChoiceQuestionComponents2.Count; i++)
            {
                MultiChoiceQuestionComponents2[i].SetActive(true);
            }
        }
        else if (modual2Pick == 1)
        {
            modual2Picks[1].SetActive(true);

            for (int i = 0; i < TypingQuestionComponents2.Count; i++)
            {
                TypingQuestionComponents2[i].SetActive(true);
            }
        }
        else if (modual2Pick == 2)
        {
            modual2Picks[2].SetActive(true);

            for (int i = 0; i < ButtonSelectQuestionComponents2.Count; i++)
            {
                ButtonSelectQuestionComponents2[i].SetActive(true);
            }
        }

        if (modual3Pick == 0)
        {
            modual3Picks[0].SetActive(true);

            for (int i = 0; i < MultiChoiceQuestionComponents3.Count; i++)
            {
                MultiChoiceQuestionComponents3[i].SetActive(true);
            }
        }
        else if (modual3Pick == 1)
        {
            modual3Picks[1].SetActive(true);

            for (int i = 0; i < TypingQuestionComponents3.Count; i++)
            {
                TypingQuestionComponents3[i].SetActive(true);
            }
        }
        else if (modual3Pick == 2)
        {
            modual3Picks[2].SetActive(true);

            for (int i = 0; i < ButtonSelectQuestionComponents3.Count; i++)
            {
                ButtonSelectQuestionComponents3[i].SetActive(true);
            }
        }
    }

    public void TimerStartFunction()
    {
        GetComponent<TimeSelectScript>();

        time = TimeSelectScript.timerValue;
        Timer.SetActive(true);
        print(time);

        StartCoroutine(Time());

    }

    IEnumerator Time()
    {
        while (true)
        {
            ConvertToMinutes(time);
            yield return new WaitForSeconds(1);
            time = time - 1;
            
        }
    }

    public void ConvertToMinutes(float seconds)
    {

        int minutes = 0;
        

        while (seconds >= 60)
        {
            seconds = seconds - 60;
            minutes++;
        }

        string minutesText = minutes.ToString();
        string secondsText = seconds.ToString();

        if (secondsText.Length == 1)
        {
            timeText.text = minutesText + ":" + "0" + secondsText;
        }
        else
        {
            timeText.text = minutesText + ":" + secondsText;
        }

    }

    /*public void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        print(timeText);

    }*/

    // Update is called once per frame
    void Update()
    {
        GetComponent<TimestablesSelectScript>();

        condition1 = TimestablesSelectScript.timestablesConfirmBool;

        GetComponent<TimeSelectScript>();

        condition2 = TimeSelectScript.timeConfirmationBool;

        if (condition1 == true && condition2 == true)
        {
            print("IS THIS LOOPING IDK");
            GameStartFunction();
            this.enabled = false;
        }

    }

}