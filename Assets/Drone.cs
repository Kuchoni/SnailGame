using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Rigidbody2D target;
    Vector2 direction;
    float speed = 3f;
    float timer = 2f;
    bool moving;
    int movecount;
    public GameObject destroy;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        moving = false;
        direction = new Vector2(0, 0);
        movecount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (movecount>=3)
        {
            Destroy(gameObject);
            GameObject destroyRef = Instantiate(destroy);
            destroyRef.transform.position = transform.position;
        }
        if (!moving)
        {
            timer -= Time.deltaTime;
            if (timer<=0)
            {
                moving = true;
                direction = (target.position - rb2d.position).normalized;
                timer = 1.5f;
            }
        }
        else
        {
            timer -= Time.deltaTime;
            if (timer<=0)
            {
                moving = false;
                direction *= 0;
                timer = 2f;
                movecount++;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector2 newPos = rb2d.position + direction * speed * Time.deltaTime;
        rb2d.MovePosition(newPos);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;
        if (other.tag!="Enemy"&&other.tag!="Projectile"&&other.tag!="EProj")
        {
            Destroy(gameObject);
            GameObject destroyRef = Instantiate(destroy);
            destroyRef.transform.position = transform.position;
        }
    }
}
