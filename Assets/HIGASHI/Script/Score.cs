using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    Text ScoreTexts;
    float ScoreTime;
    Life Lf;


	// Use this for initialization
	void Start () {

        ScoreTexts = GetComponent<Text>();
        var gbjLf = GameObject.Find("Life");
        Lf = gbjLf.GetComponent<Life>();



    }
	
	// Update is called once per frame
	void Update () {

        ScoreTime += Time.deltaTime * 10;
        if(Lf.point <=0)
        {
            ScoreTime -= Time.deltaTime * 10;
            
        }

        

        ScoreTexts.text = "Score :" + ScoreTime.ToString("F2");



        



	}
}
