using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnPointBudda : MonoBehaviour 
{
	public GameObject budda;
    public int r = 8;
	public GameObject prefab;
    System.Random rnd = new System.Random();
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 3f);
    }
    void Spawn()
	{
        for (int i=0;i<rnd.Next(0,3);i++)
        {
            int k = r * 100;
			float y = rnd.Next(0, k);
            y = y / 100;
            float z = Convert.ToSingle(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(y, 2)));
			int znak = rnd.Next (0, 2);
			if (znak == 0) {
				z = -z;
			}
            GameObject child = Instantiate(prefab, new Vector3(3.5f, y + 1, z), Quaternion.Euler(0, 0, 0));
			child.transform.parent = budda.transform;
    }
}
}
