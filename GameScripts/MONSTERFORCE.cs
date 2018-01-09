using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MONSTERFORCE : MonoBehaviour {
	public float speed = 3;
	void Update () {
 		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position,new Vector3(0, 1.5f, 0), step);

	}
}
