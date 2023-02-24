using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void CargarNivel()
    {
        SceneManager.LoadScene("Level 1");
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
        Application.Quit();
    }
}
