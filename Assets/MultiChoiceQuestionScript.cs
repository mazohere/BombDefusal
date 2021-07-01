using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MultiChoiceQuestionScript : MonoBehaviour
{
    public bool condition1;
    public bool condition2;
    public Text Question;
    public Button Answer0;
    public Button Answer1;
    public Button Answer2;
    public Text Answer0_text;
    public Text Answer1_text;
    public Text Answer2_text;
    public int correctNumber = 0;
    public List<int> firstNumber;
    public static bool multiChoiceQuestionSuccess;

    void Update()
    {
        GetComponent<TimestablesSelectScript>();

        condition1 = TimestablesSelectScript.timestablesConfirmBool;

        GetComponent<TimeSelectScript>();

        condition2 = TimeSelectScript.timeConfirmationBool;

        if (condition1 == true && condition2 == true)
        {
            GetComponent<TimestablesSelectScript>();

            firstNumber = TimestablesSelectScript.timestablesChoice;


            FirstQuestion();

            this.enabled = false;
           
        }
        
    }

    public void FirstQuestion()
    {

        int correctAnswer = Random.Range(0, 3);
        correctNumber = correctAnswer;
        print(correctAnswer);

        //Based on what the correctAnswer variable is, the corresponding button gets assigned an atribute such as "correct", then
        //I write code for the correct variable.

        int scriptFirstNumber = firstNumber[Random.Range(0, firstNumber.Count)];
        print(firstNumber[Random.Range(0, firstNumber.Count)]);
        print(scriptFirstNumber);





        int firstWrong = Random.Range(1, 100);
        int secondWrong = Random.Range(1, 100);
        int secondNumber = Random.Range(1, 13);
        int questionText = (scriptFirstNumber * secondNumber);
        print(questionText);

        if (firstWrong == questionText)
        {
            firstWrong = firstWrong - 1;
        }

        if (secondWrong == questionText)
        {
            secondWrong = secondWrong - 1;
        }

        if (correctAnswer == 0)
        {
            CorrectButton(Answer0_text, firstWrong, secondWrong, Answer1_text, Answer2_text, questionText);
        } else if (correctAnswer == 1)
        {
            CorrectButton(Answer1_text, firstWrong, secondWrong, Answer2_text, Answer0_text, questionText);
        }else if (correctAnswer == 2)
        {
            CorrectButton(Answer2_text, firstWrong, secondWrong, Answer1_text, Answer0_text, questionText);
        }






        Question.text = (scriptFirstNumber + " * " + secondNumber).ToString();
    }

    public void CorrectButton(Text buttonNumber, int scriptFirstNumber, int secondNumber, Text wrongButton1, Text wrongButton2, int questionText)
    {
        buttonNumber.text = (questionText).ToString();
        wrongButton1.text = (scriptFirstNumber).ToString();
        wrongButton2.text = (secondNumber).ToString();
    }


    private void Start()
    {

    }

    public void OnAnswerClick(int buttonNumber)
    {
        multiChoiceQuestionSuccess = false;

        Answer0.interactable = false;
        Answer1.interactable = false;
        Answer2.interactable = false;

        print(buttonNumber);
        if (buttonNumber == correctNumber)
        {
            multiChoiceQuestionSuccess = true;
            print("right");
            // right
        } else
        {
            print("wrong");
            // weromng
        }
    }
}
