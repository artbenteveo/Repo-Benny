using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
public class Logros : AchievementRules
{ 
	public virtual void OnMMEvent(CorgiEngineEvent corgiEngineEvent)
	{
		switch (corgiEngineEvent.EventType)
		{
			case CorgiEngineEventTypes.LevelEnd:
				MMAchievementManager.UnlockAchievement("PrincessInAnotherCastle");
				break;
			case CorgiEngineEventTypes.PlayerDeath:
				MMAchievementManager.UnlockAchievement("DeathIsOnlyTheBeginning");
				break;
		}
	}

	public virtual void OnMMEvent(PickableItemEvent pickableItemEvent)
	{
		Debug.Log("Recogío algo");

		if (pickableItemEvent.PickedItem != null)
		{
			if (pickableItemEvent.PickedItem.GetComponent<Coin>() != null)
			{
				MMAchievementManager.AddProgress ("MoneyMoneyMoney", 1);
			}
			if (pickableItemEvent.PickedItem.GetComponent<Stimpack>() != null)
			{
				MMAchievementManager.UnlockAchievement ("Medic");
			}
		}
	}
}

