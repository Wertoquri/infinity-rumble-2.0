using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{
    public float speed = 10f;
    public TMP_Text ScoreText;
    private float directionMove;
    private Rigidbody2D rb2d;
    private int score = 0;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directionMove = Input.GetAxis("Horizontal") * speed;
        //directionMove = Input.acceleration.x * speed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb2d.velocity;
        velocity.x = directionMove;
        rb2d.velocity = velocity;
        if(transform.position.x > score)
        {
            score = System.Convert.ToInt32(transform.position.y);
            ScoreText.text = score.ToString();
        }
    }
}
