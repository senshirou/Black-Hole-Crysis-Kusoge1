using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackhole : MonoBehaviour {

    Transform move;
    float speed = 15f;
    Rigidbody rig;
    float timer;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        rig.AddForce(transform.forward * speed);
        if(timer>=10f)
        {
            Destroy(gameObject);
        }

	}

    
}
