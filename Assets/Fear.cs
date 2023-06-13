using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fear : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 direction;
    public SpriteRenderer render;
    public Rigidbody2D target;

    float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        speed = Random.Range(1.5f, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) { 
        Vector2 pointB = target.position;
        Vector2 pointA = rb2d.position;
        Vector2 distance = pointB - pointA;
        if (distance.magnitude < 5)
        {
            direction = distance.normalized * -1;
        }
        else if (distance.magnitude < 15)
        {
            direction = distance.normalized;
        }
        if (direction.x > 0)
        {
            render.flipX = false;
        }
        else
        {
            render.flipX = true;
        }
        }
        else
        {
            direction *= 0;
        }
    }
    void FixedUpdate()
    {
        Vector2 newPos = rb2d.position + direction * speed * Time.deltaTime;
        rb2d.MovePosition(newPos);
    }


}
