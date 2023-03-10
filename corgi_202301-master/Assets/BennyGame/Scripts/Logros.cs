using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Logros : AchievementRules
{ 

	public virtual void OnMMEvent(PickableItemEvent pickableItemEvent)
	{
		Debug.Log("Recogío algo");

		if (pickableItemEvent.PickedItem != null)
		{
			if (pickableItemEvent.PickedItem.GetComponent<Coin>() != null)
			{
				//MMAchievementManager.AddProgress ("MoneyMoneyMoney", 1);
			}
			if (pickableItemEvent.PickedItem.GetComponent<Stimpack>() != null)
			{
				//MMAchievementManager.UnlockAchievement ("Medic");
			}
		}
	}

	/// <summary>
	/// On enable, we start listening for MMGameEvents. You may want to extend that to listen to other types of events.
	/// </summary>
	protected override void OnEnable()
	{
		base.OnEnable();
		this.MMEventStartListening<PickableItemEvent>();
	}

	/// <summary>
	/// On disable, we stop listening for MMGameEvents. You may want to extend that to stop listening to other types of events.
	/// </summary>
	protected override void OnDisable()
	{
		base.OnDisable();
		this.MMEventStopListening<PickableItemEvent>();
	}
}

