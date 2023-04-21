using UnityEngine;
using System.Collections;
using MoreMountains.Tools;

namespace MoreMountains.CorgiEngine
{
	/// <summary>
	/// Coin manager
	/// </summary>
	[AddComponentMenu("Corgi Engine/Items/Atomic")]
	public class PickableAtomic : PickableItem
	{
        public GameObject objects;
		[Header("Atomic")]

		/// The amount of points to add when collected
		[Tooltip("The amount of points to add when collected")]
		public int PointsToAdd = 10;

		/// <summary>
		/// Triggered when something collides with the coin
		/// </summary>
		/// <param name="collider">Other.</param>
		protected override void Pick(GameObject picker) 
		{
			// we send a new points event for the GameManager to catch (and other classes that may listen to it too)
			CorgiEnginePointsEvent.Trigger(PointsMethods.Add, PointsToAdd);
            objects.SetActive(true);
		}
	}
}