using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporalObject : MonoBehaviour {

    public GameObject Temporal_Object;
    public float LengthOfTime;
    float TimeAtStartOfScene;

	// Use this for initialization
	void Start () {

        TimeAtStartOfScene = Time.time;
        Temporal_Object.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {

        if ((Time.time - TimeAtStartOfScene) > LengthOfTime)
            Temporal_Object.SetActive(false);
		
	}
}
