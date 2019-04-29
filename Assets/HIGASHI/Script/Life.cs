using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    public float point = 3;
    public Text scoretext;
    Life Lf;
    

	// Use this for initialization
	void Start () {

        scoretext = GetComponent<Text>();
        


    }
	
	// Update is called once per frame
	void Update () {

        

		
	}

    public void life()
    {
        
        point = point -1;
        scoretext.text = point.ToString();
        
        
    }

    
}
