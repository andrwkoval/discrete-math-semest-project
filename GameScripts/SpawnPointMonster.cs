using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnPointMonster : MonoBehaviour 
{
	Vector3[] positionArray = new [] {new Vector3(2.5f, 0.5f, 1.25f), new Vector3(2.5f, 0.5f, -1.25f)};
	public GameObject monst_prefab;
	public GameObject monster;
	public float speed = 1;
	System.Random rnd = new System.Random();

	void Start ()
	{
		InvokeRepeating("Spawn", 2f, 3f);
	}
	void Spawn()
	{
		
		GameObject child = Instantiate(monst_prefab, positionArray[rnd.Next(0, positionArray.Length + 1)], Quaternion.Euler(0, 0, 0));
		child.transform.parent = monster.transform;
	}
}
