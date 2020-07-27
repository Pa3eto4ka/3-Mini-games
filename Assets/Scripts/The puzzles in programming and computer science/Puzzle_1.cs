using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puzzle_1 : MonoBehaviour
{
    public string theName;
    public GameObject InputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        theName = InputField.GetComponent<Text>().text;
        if (theName == "Python" || theName == "python")
        {
            textDisplay.GetComponent<Text>().text = "Верный ответ";
            Invoke("NextLevel", 3);
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "Неверно! Попробуйте еще раз."; 
        }
    }
    void NextLevel()
    {
        Application.LoadLevel("Puzzle 2");
    }
}
