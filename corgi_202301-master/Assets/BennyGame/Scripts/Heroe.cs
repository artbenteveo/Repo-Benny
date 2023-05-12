using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;

public class Heroe : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private int tiempo_inmunidad;
    private Health health;
    
    public virtual void OnMMEvent(MMGameEvent e){

        if(e.EventName == "PickUpPowerUpEvent")
        {
            //health = LevelManager.Instance.Players[0].GetComponent<Health>();
            health = this.GetComponent<Health>();
            Debug.Log("Empezar inmortal");
            health.DamageDisabled();
            StartCoroutine(VolverMortal());
        }
    }

    IEnumerator VolverMortal(){
        yield return new WaitForSecondsRealtime(tiempo_inmunidad);
        health.DamageEnabled();
        Debug.Log("Otra vez mortal");
    }
        // Start is called before the first frame update
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
}
