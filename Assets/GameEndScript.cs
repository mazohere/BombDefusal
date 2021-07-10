using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEndScript : MonoBehaviour
{
    public List<GameObject> everything;
    public GameObject success;
    public GameObject successSubtitle;
    public GameObject fail;
    public GameObject failSubtitle;
    public List<GameObject> menu;



    bool L0WinCheck;
    bool L1WinCheck;
    bool L2WinCheck;
    bool L3WinCheck;

    bool L0LoseCheck;
    bool L1LoseCheck;
    bool L2LoseCheck;
    bool L3LoseCheck;

    public AudioClip[] gameEndSound;


    void GameSuccessFunction()
    {
        for (int i = 0; i < everything.Count; i++)
        {
            everything[i].SetActive(false);
        }

        success.SetActive(true);
        successSubtitle.SetActive(true);
        GetComponent<AudioSource>().clip = gameEndSound[0];
        GetComponent<AudioSource>().Play();


    }

    void GameFailFunction()
    {
        for (int i = 0; i < everything.Count; i++)
        {
            everything[i].SetActive(false);
        }

        fail.SetActive(true);
        failSubtitle.SetActive(true);
        GetComponent<AudioSource>().clip = gameEndSound[1];
        GetComponent<AudioSource>().Play();


    }

    

    // Update is called once per frame
    void Update()
    {
        GetComponent<LightScript>();

        L0WinCheck = LightScript.L0Win;
        L1WinCheck = LightScript.L1Win;
        L2WinCheck = LightScript.L2Win;
        L3WinCheck = LightScript.L3Win;

        L0LoseCheck = LightScript.L0Lose;
        L1LoseCheck = LightScript.L1Lose;
        L2LoseCheck = LightScript.L2Lose;
        L3LoseCheck = LightScript.L3Lose;



        if (L0WinCheck == true && L1WinCheck == true && L2WinCheck == true && L3WinCheck == true)
        {
            GameSuccessFunction();
            this.enabled = false;
        }

        if (L0LoseCheck == true || L1LoseCheck == true || L2LoseCheck == true || L3LoseCheck == true)
        {
            GameFailFunction();
            this.enabled = false;
        }
    }
}
