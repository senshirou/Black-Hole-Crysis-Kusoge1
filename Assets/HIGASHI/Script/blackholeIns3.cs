﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackholeIns3 : MonoBehaviour {

    public GameObject black;
    Vector3 wave;
    float time;
    float tick;
    float times;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        times += Time.deltaTime;
        wave = new Vector3(190, 0,(Random.Range(-190, 190)));



        if (time >= 100f)
        {
            Instantiate(black, wave, transform.rotation);
            time = 97;
        }

        if (times >= 102f)
        {
            Instantiate(black, wave, transform.rotation);
            times = Random.Range(99, 101);
        }







    }
}
