using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public static Singleton inst;

    void Awake()
    {
        if (Singleton.inst == null)
        {
            Singleton.inst = this;
            DontDestroyOnLoad(gameObject);

        } 
        else 
        {
            Destroy(gameObject);
        }
    }     

}
