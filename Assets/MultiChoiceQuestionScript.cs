using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MultiChoiceQuestionScript : MonoBehaviour
{
    public Text Question;
    public Button Answer0;
    public Button Answer1;
    public Button Answer2;
    public Text Answer0_text;
    public Text Answer1_text;
    public Text Answer2_text;
    public int correctNumber = 0;

    public void FirstQuestion()
    {

        int correctAnswer = Random.Range(0, 3);
        correctNumber = correctAnswer;
        print(correctAnswer);

        //Based on what the correctAnswer variable is, the corresponding button gets assigned an atribute such as "correct", then
            //I write code for the correct variable.

        

        

        int firstWrong = Random.Range(1, 100);
        int secondWrong = Random.Range(1, 100);
        int firstNumber = Random.Range(1, 13);
        int secondNumber = Random.Range(1, 13);
        int questionText = (firstNumber * secondNumber);
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






        Question.text = (firstNumber + " * " + secondNumber).ToString();

    }

    public void CorrectButton(Text buttonNumber, int firstNumber, int secondNumber, Text wrongButton1, Text wrongButton2, int questionText)
    {
        buttonNumber.text = (questionText).ToString();
        wrongButton1.text = (firstNumber).ToString();
        wrongButton2.text = (secondNumber).ToString();
    }

    private void Start()
    {
        FirstQuestion();

    }

    public void OnAnswerClick(int buttonNumber)
    {
        print(buttonNumber);
        if (buttonNumber == correctNumber)
        {
            print("right");
            // right
        } else
        {
            print("wrong");
            // weromng
        }
    }
}
