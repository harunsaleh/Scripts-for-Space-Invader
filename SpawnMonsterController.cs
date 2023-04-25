using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpawnMonsterController : MonoBehaviour
{
    public GameObject Monster1;
    public GameObject Monster2;

    public float interval = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    void SpawnMonster()
    {
        float v = Random.value;

        if (v < 0.2)
        {
            GameObject g = Instantiate(Monster1, transform.position, Quaternion.identity);
        }
        else if (v < 0.4) 
        {
            GameObject g = Instantiate(Monster2, transform.position, Quaternion.identity);
        }

        
    }
}
