using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class TimestablesSelectScript : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;
    public Button Button7;
    public Button Button8;
    public Button Button9;
    public Button Button10;
    public Button Button11;
    public Button Button12;
    public Button ButtonSelectAll;
    public Button ButtonDeselectAll;
    public Button Confirm;
    public List<Button> allButtons;
    public static List<int> timestablesChoice = new List<int>();
    public static bool timestablesConfirmBool = false;

    public void OnButtonClick(string choice)
    {
        
        string[] checkTimestables = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };

        print(choice);

        if (Array.IndexOf(checkTimestables, choice) != -1)
        {
            allButtons[int.Parse(choice) - 1].GetComponentInChildren<Image>().color = Color.red;
            allButtons[int.Parse(choice) - 1].interactable = false;
            int intChoice = int.Parse(choice);
            timestablesChoice.Add(intChoice);
            
            foreach (var x in timestablesChoice)
            {
                Debug.Log(x.ToString());
            }
            
        }
        else if (choice == "Select All")
        {
            for (int i = 0; i < allButtons.Count; i++)
            {
                allButtons[i].GetComponentInChildren<Image>().color = Color.red;
                allButtons[i].interactable = false;
                print(allButtons[i]);
                timestablesChoice.Add(i + 1);
            }

            timestablesChoice = timestablesChoice.Distinct().ToList();



            foreach (var x in timestablesChoice)
            {
                Debug.Log(x.ToString());
            }
        }
        else if (choice == "Deselect All")
        {
            for (int i = 0; i < allButtons.Count; i++)
            {
                allButtons[i].GetComponentInChildren<Image>().color = Color.white;
                allButtons[i].interactable = true;
                timestablesChoice.Remove(i + 1);
            }

            foreach (var x in timestablesChoice)
            {
                Debug.Log(x.ToString());
            }

        }
        else if (choice == "Confirm")
        {
            foreach (var x in timestablesChoice)
            {
                Debug.Log(x.ToString());
            }
            if (timestablesChoice?.Any() == false)
            {
                print("You must select timestables before proceeding");
            }
            else
            {
                print("works");
                //set timestablesConfirm bool to true; disable everything;
                for (int i = 0; i < allButtons.Count; i++)
                {
                    allButtons[i].interactable = false;
                }
                ButtonSelectAll.interactable = false;
                ButtonDeselectAll.interactable = false;
                Confirm.interactable = false;

                timestablesConfirmBool = true;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
