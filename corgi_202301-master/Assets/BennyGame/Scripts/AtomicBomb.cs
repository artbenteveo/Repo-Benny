using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomicBomb : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;
    public GameObject gatetoNextLevel;

    void Start()
    {
      		for(int i=0; i< 10; i++)
		{
			enemies[i].SetActive(false);
		}
    gatetoNextLevel.SetActive(true);
    }

}
