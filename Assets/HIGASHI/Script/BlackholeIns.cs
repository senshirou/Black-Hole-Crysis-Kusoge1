using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeIns : MonoBehaviour {

    public GameObject black;
    Vector3 wave;
    float time;
    float tick;
    float times;
    [SerializeField] AudioSource audio;
    

	// Use this for initialization
	void Start () {

        audio = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;
        times += Time.deltaTime;
        wave = new Vector3(-190,0,Random.Range(-190, 190));
        

	//test
        if (time >= 3f)
        {
            Instantiate(black, wave, transform.rotation);
            audio.PlayOneShot(audio.clip);
            time = 0;
        }

        if(times >= 4f)
        {
            Instantiate(black, wave, transform.rotation);
            audio.PlayOneShot(audio.clip);
            times = Random.Range(3,5);
        }

        

        

        
		
	}
}
