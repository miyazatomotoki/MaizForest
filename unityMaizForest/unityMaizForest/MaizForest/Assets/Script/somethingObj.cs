using UnityEngine;
using System.Linq;
using System;

public class somethingObj : MonoBehaviour
{
    public GameObject[] Key;
    void Start()
    {
        //10回繰り返してみる
        for (int i = 0; i < 1; i++)
        {
            //Debug.Log("-------------------");

            var ary = Enumerable.Range(0, 3).OrderBy(n => Guid.NewGuid()).Take(3).ToArray();

            for (int s = 0; s < ary.Length; s++)
            {
                Debug.Log(ary[s]);
                switch (s)
                {
                    case 0:
                        Instantiate(Key[ary[s]], new Vector3(1f, 2.0f, 0.0f), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(Key[ary[s]], new Vector3(2f, 2.0f, 0.0f), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(Key[ary[s]], new Vector3(3f, 2.0f, 0.0f), Quaternion.identity);
                        break;
                }
                
            }
        }
    }
}