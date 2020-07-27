using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Code_5 : MonoBehaviour
{
    public string theName;
    public GameObject InputField;
    public GameObject textDisplay;
    int i = 0;

    public void StoreName()
    {
        theName = InputField.GetComponent<Text>().text;
        if (theName == "735")
        {
            if (i == 0)
            {
                i++;
                textDisplay.GetComponent<Text>().text = "Первый верный ответ";
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "Неверный ответ. Попробуйте еще раз";
            }
        }
        else if (theName == "2236,5")
        {
            if (i == 0)
            {
                textDisplay.GetComponent<Text>().text = "Неверный ответ. Попробуйте еще раз";
            }
            else if (i == 1)
            {
                i++;
                textDisplay.GetComponent<Text>().text = "Второй верный ответ";
                
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "Неверный ответ. Попробуйте еще раз";
            }

        }
        else if (theName == "-11,83")
        {
            if (i < 2)
            {
                textDisplay.GetComponent<Text>().text = "Неверный ответ. Попробуйте еще раз";
            }
            else
            {
                textDisplay.GetComponent<Text>().text = "Третий верный ответ. Все верно!";
                Invoke("NextLevel", 2);
            }
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Неверно! Попробуйте еще раз.";
        }
    }

    void NextLevel()
    {
        Application.LoadLevel("All Level On Screen Excellent");
    }
}