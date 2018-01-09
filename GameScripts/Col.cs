using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Col : MonoBehaviour {
    public GameObject ParticlePrefab;
	private int count = 0;
	public Text scoreCounter;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "budda(Clone)")
		{
            Instantiate(ParticlePrefab, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
			count += 1;
			scoreCounter.text = "Collected Buddas: " + count.ToString ();
        }
        if (col.gameObject.name == "Monster(Clone)")
        {
            Vector3 dir = transform.position - col.transform.position;
            dir.Normalize();
            col.GetComponent<Rigidbody>().AddForce(-dir * 100);
            Destroy(col.gameObject, 2f);
        }
	}
}