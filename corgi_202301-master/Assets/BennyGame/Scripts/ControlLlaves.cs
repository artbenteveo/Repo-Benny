using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ControlLlaves : MonoBehaviour
{
    [SerializeField]
    //H
    private TMP_Text txt_contador_llaves;
    private int contador_llaves;


    public void ActualizarPuntaje(int valor)
    {
        contador_llaves += valor;
        ActualizarValorUI();
    }

    // Update is called once per frame
    protected void ActualizarValorUI()
    {
        txt_contador_llaves.text = "" + contador_llaves;
    }

    public int ContadorLlaves()
    {
        return contador_llaves;
    }
}
