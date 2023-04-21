using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public event EventHandler EveryoneisDead;
    bool alreadyPicked = false;
    public GameObject explosion;
    public GameObject diabloBailarin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (explosion.activeSelf)
        {
            if(alreadyPicked == false)
            {
                diabloBailarin.SetActive(true);
                alreadyPicked = true;
            }


        }
    }
}
