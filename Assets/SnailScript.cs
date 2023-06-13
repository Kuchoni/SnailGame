using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailScript : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public Vector2 direction;
    public float speed = 3f;
    public SpriteRenderer render;
    float dash = 0.25f;
    public Stamina stam;
    public GameObject dust;
    public GameObject mine;
    // Start is called before the first frame update
    void Start()
    {
        
        rb2d= GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        stam = GetComponent<Stamina>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        if (direction.x > 0)
        {
            render.flipX = false;
        }
        else if (direction.x < 0)
        {
            render.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space)&&stam.stamina>=500&&dash==0.25f)
        {
            speed *= 4f;
            dash-=0.00001f;
            stam.stamina -= 500;
            GameObject mineRef = Instantiate(mine);
            mineRef.transform.position = transform.position;

        }
        if (dash<0.25f)
        {
            dash-=Time.deltaTime;
        }
        if (dash<=0)
        {
            dash = 0.25f;
            speed /= 4f;
        }
        
    }

     void FixedUpdate()
    {
        
        Vector2 newPos = rb2d.position + direction * speed*  Time.deltaTime;
        if (newPos != rb2d.position)
        {
            int number = Random.Range(0, 100);
            if (number * speed > 296) { 
            GameObject dustRef = Instantiate(dust);
            dustRef.transform.position = transform.position;
        }
        }
        rb2d.MovePosition(newPos);
    }

    
}
