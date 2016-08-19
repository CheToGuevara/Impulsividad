using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {

    public GameObject[] roads;
    int road_actual = 2 ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RoadForward()
    {
        roads[road_actual].transform.Translate(0, 0, 90) ;
        road_actual = (road_actual + 1) % 3;

    }
}
