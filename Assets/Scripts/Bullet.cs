using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bullet, gun;
    float fireRate, nextFire;

    void Start()
    {
        fireRate = 1f;
        nextFire = Time.time;
    }
    void Update()
    {
        int direction;

        //int direction = transform.position.x < GameObject.Find("Square (1)").transform.position.x ? 1 : -1;

        if (transform.position.x < GameObject.Find("Square (1)").transform.position.x)
            direction = 1;
        else
            direction = -1;

        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * direction, transform.localScale.y, 1);

        CheckIfTimeToFire();
    }
    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, new Vector2(gun.transform.position.x, gun.transform.position.y), gun.transform.rotation);
            nextFire = Time.time + fireRate;
        }
    }
}
