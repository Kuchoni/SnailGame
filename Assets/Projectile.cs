using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 direction;
    public float speed = 7f;
    public SpriteRenderer render;
    public GameObject destroy;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (direction.x > 0)
        //{
        //    render.flipX = true;
        //}
        //else if (direction.x < 0)
        //{
        //    render.flipX = false;
        //}
    }

    private void FixedUpdate()
    {
        Vector2 newPos = rb2d.position + direction * speed * Time.deltaTime;
        rb2d.MovePosition(newPos);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle += 180;
        rb2d.rotation = angle;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject other = collision.gameObject;
        
        if (other.tag != "Player" && other.tag != "Projectile" && other.tag != "EProj")
        {
            Destructable destructable = other.GetComponent <Destructable> ();
            if (destructable!=null)
            {
                destructable.Damage(1);
            }
            Destroy(gameObject);
            GameObject destroyRef = Instantiate(destroy);
            destroyRef.transform.position = transform.position;
        }
    }

}
