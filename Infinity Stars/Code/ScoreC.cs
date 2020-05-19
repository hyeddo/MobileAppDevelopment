using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreC : MonoBehaviour
{

    //**public Text countT;  //static 하면 안됨

    //**public Canvas wining;

    // public static int count;


    // Use this for initialization
    void Start()
    {
        //count = 0;
     //888  SetCountText();

    //88    wining.enabled = false;


    }

    private void Update()
    {
     //**   SetCountText();
    }
    /*88
    void SetCountText()
    {
        countT.text = "COIN : " + Hit.coin1.ToString();
        if (Hit.coin1 >= 300)
        {
            wining.enabled = true;
        }
    }*/

    /*88
    public void Restart2()
    {//gameover되고 다시 시작 //만들어서쓰면돼  

        Hit.coin1 = 0;

        wining.enabled = false;

        countT.text = "COIN : 0";

  //      SceneManager.LoadScene("CJ");

    }*/

}
