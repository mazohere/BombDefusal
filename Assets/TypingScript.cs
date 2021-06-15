using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingScript : MonoBehaviour
{
    public Text questionText;
    public InputField answerField;
    public Button answerVerification;
    public int correctAnswer;

    public void Question()
    {
        int firstnumber = Random.Range(1, 13);
        int secondnumber = Random.Range(1, 13);
        correctAnswer = (firstnumber * secondnumber);
        questionText.text = (firstnumber + " * " + secondnumber).ToString();

    }

    public void OnButtonClick()
    {
        if (answerField.text == (correctAnswer).ToString())
        {
            print("correct");
        } else
        {
            print("incorrect");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Question();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
