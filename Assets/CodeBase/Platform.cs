using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [HideInInspector]
    public bool isTrap = false;

    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.relativeVelocity.y <= 0)
        {
            Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                if(isTrap)
                {
                    Destroy(gameObject);
                }
                else
                {
                    Destroy(gameObject, 5f);
                }
            }
        }
    }
}
