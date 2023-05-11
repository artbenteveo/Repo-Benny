using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class TiempoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MMEventManager.TriggerEvent(new MMGameEvent("TiempoEvent"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
