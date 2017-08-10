using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject background;

	public static GameManager instance = null;
	[HideInInspector] public bool playersTurn = true;
	public GameObject player;
	public GameObject enemy;
	//fight characters arrays
	public GameObject[] playerTeam;
	public GameObject[] enemyTeam;
	//buttons

	public GameObject buttonAttack;
	public GameObject buttonPotion;
	public GameObject buttonMagic;

	private bool clicked;

	void Awake ()
	{
		Instantiate (background,new Vector3(0,7,1),Quaternion.identity);
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);
	}

	void Start (){
		initFight ();
	}

	public void initFight ()
	{
		//creating fight scene
		playerTeam = new GameObject[3];
		enemyTeam = new GameObject[3];
		playerTeam [0] = (GameObject)Instantiate (player, new Vector2 (-4, 0), Quaternion.identity);
		playerTeam [1] = (GameObject)Instantiate (player, new Vector2 (-7, 3), Quaternion.identity);
		playerTeam [2] = (GameObject)Instantiate (player, new Vector2 (-10, 0), Quaternion.identity);
		enemyTeam [0] = (GameObject)Instantiate (enemy, new Vector2 (4, 0), Quaternion.identity);
		enemyTeam [1] = (GameObject)Instantiate (enemy, new Vector2 (7, 3), Quaternion.identity);
		enemyTeam [2] = (GameObject)Instantiate (enemy, new Vector2 (10, 0), Quaternion.identity);


		for (int i = 0; i <= enemyTeam.Length - 1; i++) {
	
			if (enemyTeam [i] != null) {
				enemyTeam [i].transform.rotation = new Quaternion (0, 180, 0, 0);

			} else {
				break;
			}
		}
	}
	void Update ()
	{
		ChooseCharacter ();
	}

	void ChooseCharacter()
	{
		if (Input.GetKey (KeyCode.D)) {
			hideAllButtons ();
			playerTeam [0].transform.Find ("IconHolder").gameObject.SetActive (true);
		} else if (Input.GetKey (KeyCode.S)) {
			hideAllButtons ();
		} else if (Input.GetKey (KeyCode.W)) {
			hideAllButtons ();
			playerTeam [1].transform.Find ("IconHolder").gameObject.SetActive (true);
		} else if (Input.GetKey (KeyCode.A)) {
			hideAllButtons ();
			playerTeam [2].transform.Find ("IconHolder").gameObject.SetActive (true);
		} 
	}
	void hideAllButtons()
	{
		for (int i = 0; i < playerTeam.Length; i++) {
			playerTeam [i].transform.Find ("IconHolder").gameObject.SetActive (false);
		}
	}
}
