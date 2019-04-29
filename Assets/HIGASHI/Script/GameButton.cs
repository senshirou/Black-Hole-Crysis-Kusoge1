using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameButton : MonoBehaviour {

    Button continueb;
    Text chindtext;
    Life lfe;
    
    
    

    // Use this for initialization
    void Start() {

        continueb = GetComponent<Button>();
        continueb.interactable = false;
        chindtext = GetComponentInChildren<Text>();
        chindtext.text = "";
        var life = GameObject.Find("Life");
        lfe = life.GetComponent<Life>();
        






    }

    // Update is called once per frame
    void Update() {

        if(lfe.point ==0)
        {
            continueb.interactable = true;
            chindtext.text = "Continue";
        }

       
        

    }

    public void replay()
    {
        SceneManager.LoadScene("blackholegame");
    }

    void End()
    {
        SceneManager.LoadScene("Title");
    }

}
