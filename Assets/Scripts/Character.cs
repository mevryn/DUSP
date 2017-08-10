using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
	public int maxHealth;
	public int actualHealth;
	public int gold;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}


}

public class Player : Character
{
	public int maxEnergy;
	public int actualEnergy;

	public void Rest ()
	{
		actualEnergy = maxEnergy;

	}
		

}

public class Enemy : Character
{
	public Item[] dropList;
}

public class Humanoid : Enemy
{
	public int copperAmount;
}