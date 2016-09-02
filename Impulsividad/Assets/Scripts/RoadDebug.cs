using UnityEngine;
using System.Collections;

public class RoadDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tiempo: ");
        Debug.Log(Time.time);
    }
}
