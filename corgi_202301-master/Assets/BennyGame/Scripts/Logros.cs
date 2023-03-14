using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Logros : AchievementRules, 
		MMEventListener<MMGameEvent>, 
		MMEventListener<MMCharacterEvent>, 
		MMEventListener<CorgiEngineEvent>,
		MMEventListener<MMStateChangeEvent<CharacterStates.MovementStates>>,
		MMEventListener<MMStateChangeEvent<CharacterStates.CharacterConditions>>,
		MMEventListener<PickableItemEvent>
{ 
	public override void OnMMEvent(MMGameEvent gameEvent)
	{

		base.OnMMEvent (gameEvent);

	}
	public override void OnMMEvent(MMCharacterEvent characterEvent)
	{
		if(characterEvent.TargetCharacter.CharacterType == Character.CharacterTypes.Player)
		{
			switch(characterEvent.EventType)
			{
				case MMCharacterEventTypes.Jump:
				MMAchievementManager.AddProgress ("Pinguino Saltarín",1);
				break;
			}
		}
		
	}

	public override void OnMMEvent(CorgiEngineEvent corgiEngineEvent)
	{
		switch (corgiEngineEvent.EventType)
		{
			case CorgiEngineEventTypes.LevelEnd:
			MMAchievementManager.UnlockAchievement ("Morseaste ché");
			break;
			case CorgiEngineEventTypes.PlayerDeath:
			MMAchievementManager.UnlockAchievement ("Desaparecido en Acción");
			break;
			case CorgiEngineEventTypes.TogglePause:
			MMAchievementManager.UnlockAchievement ("Descanso con Mate");
			break;
		}
	}
	public override void OnMMEvent(PickableItemEvent pickableItemEvent)
	{
		Debug.Log("Recog�o algo");

		if (pickableItemEvent.PickedItem != null)
		{
			if (pickableItemEvent.PickedItem.GetComponent<Coin>() != null)
			{
				MMAchievementManager.AddProgress ("Devaluación", 1);
			}
			if (pickableItemEvent.PickedItem.GetComponent<Llave>() != null)
			{
				MMAchievementManager.UnlockAchievement ("¡Aquí está Benny!");
			}
			if (pickableItemEvent.PickedItem.GetComponent<PickableWeapon>() != null)
			{
				MMAchievementManager.UnlockAchievement ("El Matador");
			}
		}
	}


	/// <summary>
	/// On enable, we start listening for MMGameEvents. You may want to extend that to listen to other types of events.
	/// </summary>
	protected override void OnEnable()
	{
		base.OnEnable ();
			this.MMEventStartListening<MMCharacterEvent>();
			this.MMEventStartListening<CorgiEngineEvent>();
			this.MMEventStartListening<MMStateChangeEvent<CharacterStates.MovementStates>>();
			this.MMEventStartListening<MMStateChangeEvent<CharacterStates.CharacterConditions>>();
			this.MMEventStartListening<PickableItemEvent>();
	}

	/// <summary>
	/// On disable, we stop listening for MMGameEvents. You may want to extend that to stop listening to other types of events.
	/// </summary>
	protected override void OnDisable()
	{
		base.OnDisable ();
			this.MMEventStopListening<MMCharacterEvent>();
			this.MMEventStopListening<CorgiEngineEvent>();
			this.MMEventStopListening<MMStateChangeEvent<CharacterStates.MovementStates>>();
			this.MMEventStopListening<MMStateChangeEvent<CharacterStates.CharacterConditions>>();
			this.MMEventStopListening<PickableItemEvent>();
	}
}

