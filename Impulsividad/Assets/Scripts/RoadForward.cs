﻿using UnityEngine;
using System.Collections;

public class RoadForward : MonoBehaviour {

    Road myRoad;
    TrafficLight myTrafficLight;


	// Use this for initialization
	void Start () {
        myRoad = GameObject.Find("Movimiento").GetComponent<Road>();
        myTrafficLight = transform.parent.GetComponentInChildren<TrafficLight>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Tocado");
        Debug.Log(Time.time);
        GameObject.Find("Monitor").GetComponent<Monitoring>().EndofRoad();
        //myRoad.RoadForward();
        myTrafficLight.setRed(true);


    }
}
