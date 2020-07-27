using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Code_3 : MonoBehaviour
{
    public string theName;
    public GameObject InputField;
    public GameObject textDisplay;
    int i = 0;

    public void StoreName()
    {
        theName = InputField.GetComponent<Text>().text;
        if (theName == "50")
        {
            if (i == 0)
            {
                i++;
                textDisplay.GetComponent<Text>().text = "Первый верный ответ";
            }
            else if (i == 1)
            {
                textDisplay.GetComponent<Text>().text = "И второй ответ верен";
                Invoke("NextLevel", 3);
            }


        }
        else if (theName == "30")
        {
            if (i == 0)
            {
                i++;
                textDisplay.GetComponent<Text>().text = "Первый верный ответ";
            }
            else if (i == 1)
            {
                textDisplay.GetComponent<Text>().text = "И второй ответ верен! Все верно.";
                Invoke("NextLevel", 3);
            }
                
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Неверно! Попробуйте еще раз.";
        }
    }

    void NextLevel()
    {
        Application.LoadLevel("Code 4");
    }
}
