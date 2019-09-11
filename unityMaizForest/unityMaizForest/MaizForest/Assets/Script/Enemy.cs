using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    float spd;
    private Animator animator;

    float time; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Teleport");
        animator = GetComponent<Animator>();
        spd = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.Find("Player");
        if (spd == 0)
        {
            animator.SetBool("walk", false);
        }
        else
        {
            animator.SetBool("walk", true);
        }
        transform.root.LookAt(Player.transform);
        transform.Translate(0, 0, spd * 0.1f);
    }

    public void MStart()
    {
        StartCoroutine("Teleport");
        spd = 0.5f;
    }

    public void MStop()
    {
        StopCoroutine("Teleport");

        spd = 0;

    }

    IEnumerator Teleport()
    {
        while(true){
            Vector3 pos = GameObject.Find("Player").transform.position;
            yield return new WaitForSeconds(1);

            this.gameObject.transform.position = pos;
            yield return new WaitForSeconds(5);
        }
        
    }
    
}
