using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    float moveSpeed = 7f;
    Rigidbody2D rb;
    move target;
    Vector2 moveDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<move>();
        Destroy(gameObject, 3f);
        Debug.Log(rb.velocity);
    }

    private void Update()
    {
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Square (1)"))
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
}
