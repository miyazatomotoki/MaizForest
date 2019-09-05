using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public float spd;

    float time; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Teleport");
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.Find("Player");
        transform.root.LookAt(Player.transform);
        transform.Translate(0, 0, spd * 0.1f);
    }

    IEnumerator Teleport()
    {
        while(true){
            Vector3 pos = GameObject.Find("Player").transform.position;
            yield return new WaitForSeconds(1);

            GameObject.Find("Slender").transform.position = pos;
            yield return new WaitForSeconds(5);
        }
        
    }
    
}
