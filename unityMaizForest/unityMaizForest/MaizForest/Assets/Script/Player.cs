using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float RotSpeed;
    public float Runspeed;
    void Update()
    {
        turn(); //turnの処理をする
        move(); //moveの処理をする
    }
    void turn()
    {
        Vector3 Rot = transform.localEulerAngles;
        Rot.y += Input.GetAxis("Horizontal") * RotSpeed * Time.deltaTime;
        //A,D,←→キー押した分だけ動く　　//Time.deltaTimeで一定の時間間隔で処理
        transform.rotation = Quaternion.Euler(Rot); //ずっとRotで回り続ける
    }
    void move()
    {
        float z = Input.GetAxis("Vertical");
        z = z * Time.deltaTime * Runspeed;
        transform.Translate(0, 0, z);
    }
}
