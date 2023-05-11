using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_Over : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu_GameOver()
    {
        SceneManager.LoadScene("Menu");
    }
}
