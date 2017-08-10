using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

	public long itemID; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
public class Weapon : Item {


}

public class Consumable : Item {
	public int timeToUse;
}

public class specialItem : Item {

}