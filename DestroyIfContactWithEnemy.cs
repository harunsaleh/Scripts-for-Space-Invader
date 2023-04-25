using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfContactWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision vorhanden");

        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullets")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(gameObject);
            if (collision.gameObject.tag != "Wand")
            {
                Destroy(collision.gameObject);
            }
        }

    }
}


