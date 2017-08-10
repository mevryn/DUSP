using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour {


	public GameObject[] Characters;
	public Controls shortcutControl;
	public bool clicked;

	void OnMouseDown()
	{
		//sActivatingButtons ();
	}

	/*public void ActivatingButtons()
	{
		if (!clicked) {
			clicked = true;
			this.transform.Find ("IconHolder").gameObject.SetActive (true);
		} else {
			clicked = false;
			this.transform.Find ("IconHolder").gameObject.SetActive (false);
		}
	}*/

	public void setClicked(){

		if (!clicked) {
			clicked = true;
		} else {
			clicked = false;
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
