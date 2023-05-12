using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
public class ControlInmunidad : PickableItem, MMEventListener<PickableItemEvent>
{

    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        MMEventManager.TriggerEvent(new MMGameEvent("PickUpPowerUpEvent"));   
    }

    
}
