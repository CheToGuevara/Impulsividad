using UnityEngine;
using System.Collections;

public class Coche : MonoBehaviour {

    public float power = 3;
    public float maxspeed = 5;
    public float turnpower = 2;
    public float friction = 3;
    public Vector3 curspeed;
    Rigidbody myrigidbody;

    // Use this for initialization
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        curspeed = myrigidbody.velocity;

        if (curspeed.magnitude > maxspeed)
        {
            curspeed = curspeed.normalized;
            curspeed *= maxspeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            myrigidbody.AddForce(transform.forward * power);
            myrigidbody.drag = friction;
        }
        if (Input.GetKey(KeyCode.S))
        {
            myrigidbody.AddForce(-(transform.forward) * (power / 2));
            myrigidbody.drag = friction;
        }
        

        noGas();

    }

    void noGas()
    {
        bool gas;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            gas = true;
        }
        else
        {
            gas = false;
        }

        if (!gas)
        {
            myrigidbody.drag = friction * 2;
        }
    }
}
