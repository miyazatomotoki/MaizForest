using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    public GameObject TrueKey;
    public GameObject FalseKey;
    public GameObject Gate;
    public int key = 0;
    public Text text;
    private void Start()
    {
        TrueKey = GameObject.FindGameObjectWithTag("Player");
        FalseKey = GameObject.FindGameObjectWithTag("FalseKey");
        Gate = GameObject.FindGameObjectWithTag("Gate");
        text = this.GetComponent<Text>(); 
    }

    void Update()
    {
        
    }
    public void OnTriggerStay(Collider col)
    {
        if (key == 0)
        {
            if (col.gameObject.tag == "TrueKey" || Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("true");
                key = 1;
            }

            if (col.gameObject.tag == "FalseKey" || Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("false");
                key = 2;
            }
            text.text = "鍵を手に入れた";
            Invoke("message", 2);
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Gate")
        {
            switch (key)
            {
                case 1:
                    Destroy(Gate);
                    break;
                case 2:
                    key = 0;
                    break;
            }
        }
    }
    void message()
    {
        text.text = "";
    }

}
