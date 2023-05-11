using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using TMPro;
public class ControlTiempoManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI t1, t2,t3,t4;
    public static ControlTiempoManager Instance { get; private set; }
    public TextMeshProUGUI T1 { get => t1; set => t1 = value; }
    public TextMeshProUGUI T2 { get => t2; set => t2 = value; }
    public TextMeshProUGUI T3 { get => t3; set => t3 = value; }
    public TextMeshProUGUI T4 { get => t4; set => t4 = value; }

    void Start()
    {
        MMEventManager.TriggerEvent(new MMGameEvent("TiempoEvent"));
    }    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
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
