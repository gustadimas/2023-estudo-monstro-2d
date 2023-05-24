using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    [SerializeField] float speed;
    [SerializeField] float jump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);


        if (Input.GetButtonDown("Jump"))
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);

        if (dirX > 0)
            transform.eulerAngles = new Vector3(0, 180, 0);
        else if (dirX < 0)
            transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
