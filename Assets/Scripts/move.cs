using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float jump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump")) rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        if (Input.GetAxisRaw("Horizontal") > 0) transform.eulerAngles = new Vector3(0, 180, 0);
        else if (Input.GetAxisRaw("Horizontal") < 0) transform.eulerAngles = new Vector3(0, 0, 0);
    }
}
