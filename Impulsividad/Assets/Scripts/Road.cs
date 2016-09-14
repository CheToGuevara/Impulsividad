using UnityEngine;
using System.Collections;

public class Road : MonoBehaviour {

    public GameObject[] roads;
    public GameObject[] stoproad;    
    int last_seconds;
    int current_road;
    int current_stop;
    

	// Use this for initialization
	void Start () {
        last_seconds = roads.Length * 20 + 20;
        
        current_road = 0;
        current_stop = stoproad.Length - 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RoadForward(int seconds)
    {
        Debug.Log(seconds);
        for (int i = 0; i < seconds;i++ )
        {
            roads[current_road].transform.transform.position = new Vector3(0, 0, last_seconds);
            roads[current_road].transform.Translate(0, 0, 20 * i);
            current_road = (current_road + 1) % roads.Length;
        }
        stoproad[current_stop].transform.position = new Vector3(0, 0, last_seconds);
        stoproad[current_stop].transform.Translate(0, 0, 20 * (seconds));
        current_stop = (current_stop + 1) % stoproad.Length;
        last_seconds += seconds * 20/*Anterior*/ +20 /*Semaforo*/;
            
        

    }
}
