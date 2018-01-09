using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	private int health;
	public Text amountOfLives;
	public Text gameOverMessage;

	void Start () {
		health = 3;
		amountOfLives.text = "Health: " + health.ToString ();
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.name == "Monster(Clone)")
		{
			Destroy(other.gameObject);
			health = health - 1;
			amountOfLives.text = "Health: " + health.ToString ();
		}
		if (health == 0) {
			gameOverMessage.text = "GAME OVER";
		}
	}
}
