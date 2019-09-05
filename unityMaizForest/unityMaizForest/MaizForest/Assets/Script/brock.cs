using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brock : MonoBehaviour
{
    public GameObject zimen;
    public GameObject kabe;
    public GameObject invikabe;
    public int[,] stageArray = new int[11, 11]{
        {1,1,1,1,1,1,1,1,1,1,1},
        {1,1,1,1,1,0,0,0,1,1,1},
        {1,1,0,0,0,0,0,0,1,1,1},
        {1,1,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,1,1},
        {1,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,1,1},
        {1,0,0,0,0,0,0,0,0,1,1},
        {1,1,0,0,0,0,0,0,0,0,1},
        {1,1,1,1,1,1,1,1,1,1,1}
    };


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                if (stageArray[i, j] == 0)
                {
                    Instantiate(zimen, new Vector3(i*20, -1, j*20), Quaternion.identity);
                }
                else
                {
                    Instantiate(kabe, new Vector3(i*20, 0, j*20), Quaternion.identity);

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
