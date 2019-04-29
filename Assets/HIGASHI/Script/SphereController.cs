using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereController : MonoBehaviour {

    Rigidbody rb;
    float speed = 100f;   //プレイヤーのスピード
    float movex;　　　　　//プレイヤーX座標
    float movez;　　　　　//プレイヤーZ座標
    Life texts;　　　　　 //Life.csを宣言
    float limit = 700;　　//ポジションのリミットが250
    public GameObject bakuhatsu;   //GameObjectを取得
    Renderer Player;　　　//GameObjectのレンダラーを取得
    Collider Playerc;
    
    


	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        
        var gameobj = GameObject.Find("Life");
        texts = gameobj.GetComponent<Life>();
        
        Player = GetComponent<Renderer>();
        Playerc = GetComponent<Collider>();
        


    }
	
	// Update is called once per frame
	void Update () {

        //プレイヤーが外に出たとき最初のシーンに戻る。
        if (transform.position.x >= limit || transform.position.z >= limit || transform.position.x <= -limit || transform.position.z <= -limit)
        {
            SceneManager.LoadScene("blackholegame");

        }

        



    }

    void FixedUpdate()
    {
        movex = Input.GetAxis("Horizontal") * speed;
        movez = Input.GetAxis("Vertical") * speed;

        rb.AddForce(movex, 0, movez);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        texts.life();

        if (texts.point == 0)
        {
            Playerc.enabled = false;
            Player.enabled = false;
            Instantiate(bakuhatsu, transform.position, transform.rotation);
            Destroy(gameObject, 3f);
        }

        

    }

    
}
