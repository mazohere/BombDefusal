using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingScript : MonoBehaviour
{
    public Text questionText;
    public InputField answerField;
    public Button answerVerification;
    public int correctAnswerScriptTwo;

    public void Question()
    {
        int firstnumberscripttwo = Random.Range(1, 13);
        int secondnumberscrpittwo = Random.Range(1, 13);
        correctAnswerScriptTwo = (firstnumberscripttwo * secondnumberscrpittwo);
        print(correctAnswerScriptTwo);
        questionText.text = (firstnumberscripttwo + " * " + secondnumberscrpittwo).ToString();

    }

    public void OnButtonClick()
    {
        print("answerField: " + answerField.text);
        print("correctAnswer: " + correctAnswerScriptTwo.ToString());

        if (answerField.text == correctAnswerScriptTwo.ToString())
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
