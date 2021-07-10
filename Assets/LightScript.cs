using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightScript : MonoBehaviour
{
    public bool condition1;
    public bool condition2;

    public List<Button> mod0Multi;
    public List<Button> mod0Type;
    public List<Button> mod0Button;

    public List<Button> mod1Multi;
    public List<Button> mod1Type;
    public List<Button> mod1Button;

    public List<Button> mod2Multi;
    public List<Button> mod2Type;
    public List<Button> mod2Button;

    public List<Button> mod3Multi;
    public List<Button> mod3Type;
    public List<Button> mod3Button;

    public Image Light;
    public Image Light1;
    public Image Light2;
    public Image Light3;

    int mod0Pick;
    int mod1Pick;
    int mod2Pick;
    int mod3Pick;

    bool multiResult;
    bool typeResult;
    bool buttonResult;
    bool buttonFail;

    public static bool L0Win;
    public static bool L1Win;
    public static bool L2Win;
    public static bool L3Win;

    public static bool L0Lose;
    public static bool L1Lose;
    public static bool L2Lose;
    public static bool L3Lose;




    void LightActivation()
    {
        GetComponent<MenuScript>();

        mod0Pick = MenuScript.modual0Pick;
        mod1Pick = MenuScript.modual1Pick;
        mod2Pick = MenuScript.modual2Pick;
        mod3Pick = MenuScript.modual3Pick;

        multiResult = false;

        GetComponent<MultiChoiceQuestionScript>();

        multiResult = MultiChoiceQuestionScript.multiChoiceQuestionSuccess;

        typeResult = false;


        GetComponent<TypingScript>();

        typeResult = TypingScript.typingScriptSuccess;

        buttonResult = false;


        GetComponent<ButtonSelectScript>();

        buttonResult = ButtonSelectScript.buttonSelectScriptSuccess;

        buttonFail = false;


        GetComponent<ButtonSelectScript>();

        buttonFail = ButtonSelectScript.buttonSelectScriptFailure;


    }

    public void OnClick(int buttonQuestionValue)
    {
        
        LightActivation();

        if (mod0Pick == 0)
        {
            if (buttonQuestionValue == 0)
            {
                if (multiResult == true)
                {
                    Light.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L0Win = true;
                }
                else if (multiResult == false)
                {
                    Light.GetComponent<Image>().color = Color.red;
                    L0Lose = true;
                }
            }
        }
        else if (mod0Pick == 1)
        {
            if (buttonQuestionValue == 0)
            {
                if (typeResult == true)
                {
                    Light.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L0Win = true;
                }
                else if (typeResult == false)
                {
                    Light.GetComponent<Image>().color = Color.red;
                    L0Lose = true;
                }
            }
        }
        else if (mod0Pick == 2)
        {
            if (buttonQuestionValue == 0)
            {
                if (buttonResult == true)
                {
                    Light.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L0Win = true;
                }
                else if (buttonFail == true)
                {
                    Light.GetComponent<Image>().color = Color.red;
                    L0Lose = true;
                }
            }
        }

        if (mod1Pick == 0)
        {
            if (buttonQuestionValue == 1)
            {
                if (multiResult == true)
                {
                    Light1.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L1Win = true;
                }
                else if (multiResult == false)
                {
                    Light1.GetComponent<Image>().color = Color.red;
                    L1Lose = true;
                }
            }
        }
        else if (mod1Pick == 1)
        {
            if (buttonQuestionValue == 1)
            {
                if (typeResult == true)
                {
                    Light1.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L1Win = true;
                }
                else if (typeResult == false)
                {
                    Light1.GetComponent<Image>().color = Color.red;
                    L1Lose = true;
                }
            }
        }
        else if (mod1Pick == 2)
        {
            if (buttonQuestionValue == 1)
            {
                if (buttonResult == true)
                {
                    Light1.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L1Win = true;
                }
                else if (buttonFail == true)
                {
                    Light1.GetComponent<Image>().color = Color.red;
                    L1Lose = true;
                }
            }
        }

        if (mod2Pick == 0)
        {
            if (buttonQuestionValue == 2)
            {
                if (multiResult == true)
                {
                    Light2.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L2Win = true;
                }
                else if (multiResult == false)
                {
                    Light2.GetComponent<Image>().color = Color.red;
                    L2Lose = true; 
                }
            }
        }
        else if (mod2Pick == 1)
        {
            if (buttonQuestionValue == 2)
            {
                if (typeResult == true)
                {
                    Light2.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L2Win = true;
                }
                else if (typeResult == false)
                {
                    Light2.GetComponent<Image>().color = Color.red;
                    L2Lose = true;
                }
            }
        }
        else if (mod2Pick == 2)
        {
            if (buttonQuestionValue == 2)
            {
                if (buttonResult == true)
                {
                    Light2.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L2Win = true;
                }
                else if (buttonFail == true)
                {
                    Light2.GetComponent<Image>().color = Color.red;
                    L2Lose = true;
                }
            }
        }

        if (mod3Pick == 0)
        {
            if (buttonQuestionValue == 3)
            {
                if (multiResult == true)
                {
                    Light3.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L3Win = true;
                }
                else if (multiResult == false)
                {
                    Light3.GetComponent<Image>().color = Color.red;
                    L3Lose = true;
                }
            }
        }
        else if (mod3Pick == 1)
        {
            if (buttonQuestionValue == 3)
            {
                if (typeResult == true)
                {
                    Light3.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L3Win = true;
                }
                else if (typeResult == false)
                {
                    Light3.GetComponent<Image>().color = Color.red;
                    L3Lose = true;
                }
            }
        }
        else if (mod3Pick == 2)
        {
            if (buttonQuestionValue == 3)
            {
                if (buttonResult == true)
                {
                    Light3.GetComponent<Image>().color = Color.green;
                    GetComponent<AudioSource>().Play();
                    L3Win = true;
                }
                else if (buttonFail == true)
                {
                    Light3.GetComponent<Image>().color = Color.red;
                    L3Lose = true;
                }
            }
        }
    }

}
