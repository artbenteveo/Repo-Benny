using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private GameObject muro;
    private ControlLlaves control_llaves;

    public void Start()
    {
        // Debug.Log(this.transform.parent);
        control_llaves = this.transform.parent.GetComponent<ControlLlaves>();
    }

    public void Update()
    {
        if(control_llaves.ContadorLlaves()==2)
        {
            CambiarEstado(false);
        }
    }
    public void CambiarEstado (bool estado)
    {
        muro.SetActive(estado);
    }
}
