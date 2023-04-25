using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfContactWithObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision vorhanden");

        if (collision.gameObject.tag != "Player")
            Destroy(collision.gameObject);

    }
}


