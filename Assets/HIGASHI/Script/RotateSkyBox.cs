using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkyBox : MonoBehaviour {

    public float anglePerFrame = 0.1f;
    float rot = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        rot += anglePerFrame*0.5f;

        if(rot >=360.0f)
        {
            rot -= 360.0f;
        }
        RenderSettings.skybox.SetFloat("_Rotation", rot);
		
	}
}
