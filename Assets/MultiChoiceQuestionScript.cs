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

    public void FirstQuestion()
    {
        int correctAnswer = Random.Range(0, 3);
        print(correctAnswer);

        int firstNumber = Random.Range(1, 13);
        int secondNumber = Random.Range(1, 13);
        string questionText = firstNumber + " * " + secondNumber;

        Answer(correctAnswer)_text.text = 
        

        Question.text = questionText;

    }

    private void Start()
    {
        FirstQuestion();

    }

    public void OnAnswerClick(int buttonNumber)
    {
        print(buttonNumber);

    }
}
