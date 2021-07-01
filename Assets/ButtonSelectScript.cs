using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSelectScript : MonoBehaviour
{
    public bool condition1;
    public bool condition2;
    public List<Button> questions;
    public List<Button> answers;
    private static System.Random rng = new System.Random();
    public List<int> intAnswers;
    public int correctAnswer;
    public List<int> answeryThings;
    public int firstChilling;
    public List<int> disabledLikeNoah;
    public List<int> number1;
    public static bool button1Correct;
    public static bool button2Correct;
    public static bool button3Correct;
    public static bool buttonSelectScriptSuccess;
    public static bool buttonSelectScriptFailure;

    public void GenerateQuestions()
    {

        List<int> actualAnswers = new List<int>();

        for (int i = 0; i < questions.Count; i++)
        {
            int num1 = number1[Random.Range(0, number1.Count)];
            int num2 = Random.Range(1, 13);
            questions[i].GetComponentInChildren<Text>().text = num1 + " * " + num2;
            questions[i].name = (num1 * num2).ToString();
            actualAnswers.Add(num1 * num2);
            intAnswers.Add(num1 * num2);
        }

        Shuffle(actualAnswers);
        answeryThings = actualAnswers;


        for (int i = 0; i < answers.Count; i++)
        {
            answers[i].GetComponentInChildren<Text>().text = actualAnswers[i].ToString();
        }
    }

    public static void Shuffle(List<int> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            int value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public void OnButtonClick(int chilling)
    {
        buttonSelectScriptSuccess = false;
        buttonSelectScriptFailure = false;

        print(chilling);
        print(correctAnswer);
        print(intAnswers);
        //if the button pressed == question: grey out other questions; vice versa for answers
        if (chilling == 0)
        {
            firstChilling = 0;
            print(intAnswers[chilling]);
            correctAnswer = intAnswers[chilling];
            questions[1].interactable = false;
            questions[2].interactable = false;
        }
        else if (chilling == 1)
        {
            firstChilling = 1;
            correctAnswer = intAnswers[chilling];
            questions[0].interactable = false;
            questions[2].interactable = false;
        }
        else if (chilling == 2)
        {
            firstChilling = 2;
            correctAnswer = intAnswers[chilling];
            questions[0].interactable = false;
            questions[1].interactable = false;
        }
        else if (chilling == 3)
        {
            if (answeryThings[chilling % 3] == correctAnswer)
            {
                print("correct (ButtonSelectScript1)");
                button1Correct = true;
                questions[firstChilling].interactable = false;
                disabledLikeNoah.Add(firstChilling);
                
            }
            else
            {
                print("wrong");
                buttonSelectScriptFailure = true;
            }
            questions[0].interactable = true;
            questions[1].interactable = true;
            questions[2].interactable = true;
            for (int i = 0; i < disabledLikeNoah.Count; i++)
            {
                questions[disabledLikeNoah[i]].interactable = false;
            }
        }
        else if (chilling == 4)
        {
            if (answeryThings[chilling % 3] == correctAnswer)
            {
                print("correct (ButtonSelectScript1)");
                button2Correct = true;
                questions[firstChilling].interactable = false;
                disabledLikeNoah.Add(firstChilling);
                
            }
            else
            {
                print("wrong");
                buttonSelectScriptFailure = true;
            }
            questions[0].interactable = true;
            questions[1].interactable = true;
            questions[2].interactable = true;
            for (int i = 0; i < disabledLikeNoah.Count; i++)
            {
                questions[disabledLikeNoah[i]].interactable = false;
            }
        }
        else if (chilling == 5)
        {
            if (answeryThings[chilling % 3] == correctAnswer)
            {
                print("correct (ButtonSelectScript1)");
                button3Correct = true;
                questions[firstChilling].interactable = false;
                disabledLikeNoah.Add(firstChilling);
                
            }
            else
            {
                print("wrong");
                buttonSelectScriptFailure = true;
            }
            questions[0].interactable = true;
            questions[1].interactable = true;
            questions[2].interactable = true;
            for (int i = 0; i < disabledLikeNoah.Count; i++)
            {
                questions[disabledLikeNoah[i]].interactable = false;
            }
        }

        if (button1Correct == true && button2Correct == true && button3Correct == true)
        {
            buttonSelectScriptSuccess = true;
            button1Correct = false;
            button2Correct = false;
            button3Correct = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //OnButtonClick();
       // print("gaming");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TimestablesSelectScript>();

        condition1 = TimestablesSelectScript.timestablesConfirmBool;

        GetComponent<TimeSelectScript>();

        condition2 = TimeSelectScript.timeConfirmationBool;

        if (condition1 == true && condition2 == true)
        {
            GetComponent<TimestablesSelectScript>();

            number1 = TimestablesSelectScript.timestablesChoice;

            GenerateQuestions();
            this.enabled = false;
        }

    }

}
