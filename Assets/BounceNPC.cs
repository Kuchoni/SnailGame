using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceNPC : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 direction= Vector2.right;
    public SpriteRenderer render;
    float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d =GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        speed = Random.Range(1.5f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction.x>0)
        {
            render.flipX = false;
        }
        else if (direction.x<0)
        {
            render.flipX = true;
        }
    }

    void FixedUpdate()
    {
        Vector2 newPos = rb2d.position + direction * speed * Time.deltaTime;
        rb2d.MovePosition(newPos);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otherObject = collision.gameObject;
        Debug.Log("Collided with " + otherObject.name);
        direction *= -1;
    }

}