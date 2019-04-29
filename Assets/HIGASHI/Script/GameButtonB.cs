using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameButtonB : MonoBehaviour {

    Button back;
    Text chindtext;
    Life lfe;
    
    
    

    // Use this for initialization
    void Start() {

        back = GetComponent<Button>();
        back.interactable = false;
        chindtext = GetComponentInChildren<Text>();
        chindtext.text = "";
        var life = GameObject.Find("Life");
        lfe = life.GetComponent<Life>();
        






    }

    // Update is called once per frame
    void Update() {

        if(lfe.point ==0)
        {
            back.interactable = true;
            chindtext.text = "Back to Title";
        }

       
        

    }

    

    public void End()
    {
        SceneManager.LoadScene("Title");
    }

}
