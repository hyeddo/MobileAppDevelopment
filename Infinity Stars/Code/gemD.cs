using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemD : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)     {          if (other.tag == "plane")         {
            soundManager.instance.PlaySound();
             Debug.Log("GEM"); //enemy랑 air 붙이치면             Destroy(gameObject); //enemy 죽고


        }      }

  
}
