using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_or_exit_mini_game : MonoBehaviour
{
    public void Next_To_Menu()
    {
        SceneManager.LoadScene("Main menu");
    }
    public void Next_To_Restart_Mini_Game()
    {
        SceneManager.LoadScene("Code 1");
    }
}
