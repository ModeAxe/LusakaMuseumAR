using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateModel : MonoBehaviour {

    public float X_Speed;
    public float Y_Speed;
    public float Z_Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3 (X_Speed * Time.deltaTime, Y_Speed * Time.deltaTime, Z_Speed * Time.deltaTime));
	}
}
