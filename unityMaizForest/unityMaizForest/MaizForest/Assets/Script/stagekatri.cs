using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stagekatri : MonoBehaviour
{
    public GameObject　[] zimen;
    public GameObject kabe;
    
    public int[,] stageArray = new int[11, 11]{
        {0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,3,9,2,0,0,0},
        {0,0,3,9,9,5,8,1,0,0,0},
        {0,0,4,6,9,6,9,10,9,2,0},
        {0,3,2,4,9,2,1,3,6,5,0},
        {0,1,7,9,9,10,9,5,1,0,0},
        {0,1,1,3,2,3,9,9,8,11,0},
        {0,1,1,1,4,5,3,6,8,0,0},
        {0,4,8,4,9,2,1,1,1,0,0},
        {0,0,4,9,9,10,10,10,5,11,0},
        {0,0,0,0,0,0,0,0,0,0,0}
    };


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < stageArray.GetLength(0); i++)
        {
            for (int j = 0; j < stageArray.GetLength(1); j++)
            {
                switch(stageArray[i,j])
                {
                    case 0:
                        Instantiate(kabe, new Vector3(i * 20, 1, j * 20), Quaternion.identity);
                        break;

                    case 1:
                        Instantiate(zimen[0], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(zimen[1], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(zimen[2], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(zimen[3], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(zimen[4], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(zimen[5], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(zimen[6], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(zimen[7], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(zimen[8], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(zimen[9], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                      break;
                    case 11:
                        Instantiate(zimen[10], new Vector3(i * 20, 0, j * 20), Quaternion.identity);
                        break;
                }
                    

                    


            }
        }
    }
}
