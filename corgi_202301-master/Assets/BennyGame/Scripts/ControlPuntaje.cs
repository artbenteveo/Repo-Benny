using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuntaje : MonoBehaviour
{
    [SerializeField] private GameObject _uipuntaje;
    private ControlLlaves _controlLlaves;

    public static ControlPuntaje Instance { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        _controlLlaves = _uipuntaje.GetComponent<ControlLlaves>();
    }

    public void ActualizarPuntaje(int valor_llave)
    {
        _controlLlaves.ActualizarPuntaje(valor_llave);
    }



    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
