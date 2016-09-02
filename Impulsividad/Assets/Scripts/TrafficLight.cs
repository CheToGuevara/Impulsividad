using UnityEngine;
using System.Collections;

public class TrafficLight : MonoBehaviour {

    Animator m_anim;

	// Use this for initialization
	void Start () {
        m_anim = GetComponent<Animator>();
        m_anim.SetBool("Red", false);
        m_anim.SetBool("Green", true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    public void setRed(bool state)
    {
        m_anim.SetBool("Green", false);
        m_anim.SetBool("Red", state);
    }

    public void setGreen(bool state)
    {
        m_anim.SetBool("Red", false);
        m_anim.SetBool("Green", state);
    }



}
