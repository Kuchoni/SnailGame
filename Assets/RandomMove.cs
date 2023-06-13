using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 direction = Vector2.right;
    public SpriteRenderer render;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        speed = Random.Range(3f, 5f);
        PickDirection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Vector2 newPos = rb2d.position + direction * speed * Time.deltaTime;
        rb2d.MovePosition(newPos);
    }
    void PickDirection()
    {
        Vector2 preDir = direction;
        int choice = Random.Range(0, 4);
        if (choice==0)
        {
            direction = Vector2.right;
        }
        else if (choice == 1)
        {
            direction = Vector2.left;
        }
        else if (choice == 2)
        {
            direction = Vector2.up;
        }
        else if (choice == 3)
        {
            direction = Vector2.down;
        }
        if (direction == preDir)
            direction *= -1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PickDirection();
    }
}
