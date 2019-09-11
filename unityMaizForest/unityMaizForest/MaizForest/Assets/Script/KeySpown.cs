using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpown : MonoBehaviour
{
    public GameObject[] Key;                                        
    int number;                                                            
    int count = 0;                                                         
                                                                           
    void Start()                                                           
    {
        //var randKey = Key[number];

        for (int i = 0, len = Key.Length; i < 3; i++, len--)               
        {                                                                  
            number = Random.Range(0, Key.Length);
            
            //randKey.push(Key[number]); // 配列のランダム値に対応するインデックスを得る
            //Key[number] = Key[len -1];
            Debug.Log(Key[number]);
            // ランダムに得た値の箇所を、インデックスがlen-1(ランダム値がとりうる最大の値)の要素に置き換える
            
                Instantiate(Key[number], new Vector3(10.0f, 2.0f, 0.0f), Quaternion.identity);

           // number.Resize(ref number,)
        }
    }
}
