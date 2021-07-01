using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingScript : MonoBehaviour
{
    public bool condition1;
    public bool condition2;
    public Text questionText;
    public InputField answerField;
    public Button answerVerification;
    public int correctAnswerScriptTwo;
    public static int Test = 0;
    public List<int> firstnumberscripttwo;
    public static bool typingScriptSuccess;

    public void Question()
    {
        int scriptFirstNumberScriptTwo = firstnumberscripttwo[Random.Range(0, firstnumberscripttwo.Count)];
        int secondnumberscrpittwo = Random.Range(1, 13);
        correctAnswerScriptTwo = (scriptFirstNumberScriptTwo * secondnumberscrpittwo);
        print(correctAnswerScriptTwo);
        questionText.text = (scriptFirstNumberScriptTwo + " * " + secondnumberscrpittwo).ToString();

    }

    public void OnButtonClick()
    {
        typingScriptSuccess = false;
        print("answerField: " + answerField.text);
        print("correctAnswer: " + correctAnswerScriptTwo.ToString());

        answerVerification.interactable = false;

        if (answerField.text == correctAnswerScriptTwo.ToString())
        {
            print("correct");
            typingScriptSuccess = true;
        } else
        {
            print("incorrect");
        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
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

            firstnumberscripttwo = TimestablesSelectScript.timestablesChoice;

            Question();
            this.enabled = false;
        }

    }
}