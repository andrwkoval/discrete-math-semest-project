using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BUDDAFORCE : MonoBehaviour {
	public float speed = 10;
	void Update () {
		transform.position = new Vector3 (transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
		transform.Rotate (new Vector3 (0, 90 , 0) * Time.deltaTime);
	}
}