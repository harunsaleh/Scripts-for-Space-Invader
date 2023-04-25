using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementsController : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody2D rigidbody;
    private Animator animator;
    // Methode welches direkt beim Start des Spieles darauf zugreift
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Methode welches bei FixedUpdate eines Frames darauf zugreift.
    private void FixedUpdate()
    {
        Movement();
    }

    //Methode für die Bewegungen
    private void Movement()
    {

        //h = steht für Tastatur A & D
        float h = Input.GetAxis("Horizontal");
        // v = steht für Tastatur W & S
        float v = Input.GetAxis("Vertical");

        // Berechnung um die Bewegungsgeschwindigkeit einzustellen
        Vector2 direction = new Vector2(h, v);
        rigidbody.velocity = direction * speed;

        //Zugriff auf den Animator
       animator.SetBool("flieglinks", (h < 0));
       animator.SetBool("fliegrechts", (h > 0));
       animator.SetBool("fliegoben", (v > 0));
    }

    private void OnDisable()
    {
        SceneManager.LoadScene(0);
    }
}
