using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelectScript : MonoBehaviour
{
    public Text Question1;
    public Text Question2;
    public Text Question3;
    public Text Answer1;
    public Text Answer2;
    public Text Answer3;
    public Button question1Button;
    public Button question2Button;
    public Button question3Button;
    public Button answer1Button;
    public Button answer2Button;
    public Button answer3Button;

    public void QuestionAssignment()
    {
        //Q = Question; FN = first number; SN = second number; QT = question text; QA = question answer; Q_S = question _ select

        int Q1FN = Random.Range(1, 13);
        int Q1SN = Random.Range(1, 13);
        int Q2FN = Random.Range(1, 13);
        int Q2SN = Random.Range(1, 13);
        int Q3FN = Random.Range(1, 13);
        int Q3SN = Random.Range(1, 13);
        string QT1 = (Q1FN + " * " + Q1SN);
        string QT2 = Q2FN + " * " + Q2SN;
        string QT3 = Q3FN + " * " + Q3SN;
        int QA1 = Q1FN * Q1SN;
        int QA2 = Q2FN * Q2SN;
        int QA3 = Q3FN * Q3SN;
        print(" this is for the button one: " + QT1);
        Question1.text = QT1;
        Question2.text = QT2;
        Question3.text = QT3;
        Answer1.text = QA1.ToString();
        Answer2.text = QA2.ToString();
        Answer3.text = QA3.ToString();

        int Q1S = Random.Range(0, 3);
        int Q2S = Random.Range(0, 3);
        if (Q2S == Q1S && Q1S == 2)
        {
            Q2S = Q2S - 1;
        }
        if (Q2S == Q1S && Q1S == 0)
        {
            Q2S = Q2S + 1;
        }

        int Q3S = 0;
        if (Q1S == 0 || Q2S == 0)
        {
            Q3S = Q3S + 1;
        }
        if (Q1S == 1 || Q2S == 1)
        {
            Q3S = Q3S + 1;
        }
        if (Q1S == 2 || Q2S == 2)
        {
            Q3S = Q3S + 1;
        }

        print("Q1S: " + Q1S);
        print("Q2S: " + Q2S);
        print("Q3S: " + Q3S);


    }


    // Start is called before the first frame update
    void Start()
    {
        QuestionAssignment();
        print("gaming");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
