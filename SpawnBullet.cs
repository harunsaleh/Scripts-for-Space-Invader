using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour

{
    public GameObject bullet;
    public float interval = 1;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("Schie�e", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Schie�e()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);

    }
}
