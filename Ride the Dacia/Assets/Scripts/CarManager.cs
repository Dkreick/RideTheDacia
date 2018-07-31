using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour {

	public float speed;
    public GameObject frontWheel;
    public GameObject rearWheel;

    void Start()
    {
        frontWheel.GetComponent<WheelCollider>().steerAngle = 90;
        rearWheel.GetComponent<WheelCollider>().steerAngle = 90;
    }

	void Update ()
	{
		MovePlayer ();
	}

	void MovePlayer()
	{
		if (Input.GetKey(KeyCode.A)) 
		{
			//transform.Translate(Vector3.left * (speed * Time.deltaTime));

            frontWheel.transform.Rotate(0f, 0f, 45f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			//transform.Translate(Vector3.right * (speed * Time.deltaTime));
            frontWheel.transform.Rotate(0f, 0f, -45f);
		}
	}
}
