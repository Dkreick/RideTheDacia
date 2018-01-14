using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour {

	public float speed;

	void Update ()
	{
		MovePlayer ();
	}

	void MovePlayer()
	{
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Translate(Vector3.left * (speed * Time.deltaTime));
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * (speed * Time.deltaTime));
		}
	}
}
