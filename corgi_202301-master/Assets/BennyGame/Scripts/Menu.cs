using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public void CargarNivel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Dificultad()
    {
        SceneManager.LoadScene("DifficultySelection");
    }

    public void CargarInstrucciones()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void CargarObjetivos()
    {
        SceneManager.LoadScene("Objetivos");
    }

    public void CargarCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void CargarConfiguracion()
    {
        SceneManager.LoadScene("Configuracion");
    }

    public void Salir()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
