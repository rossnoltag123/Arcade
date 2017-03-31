using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JungleManager: MonoBehaviour {
	private float countdown = 2f;
	private float xMax = 9f; 
	private float xMin = -9f;
	private Vector2 fireSpot;

	public GameObject meteor;

	void Update () {
		FireMeteor();
	}

	void FireMeteor()
	{
		Quaternion q = Quaternion.identity;
		q.w -= 90;
		countdown -= Time.deltaTime;
		if (countdown <= 0)
		{
			ChangeFireSpot ();
			Instantiate(meteor, fireSpot, q);
			countdown = 2f;
		}
	}

	void ChangeFireSpot()
	{
		fireSpot = new Vector2(Random.Range(xMin, xMax), 5);
	}
}