using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    public GameObject shot;
    public Rigidbody2D target;
    private Drone drone1;
    private Drone drone2;
    public Vector2 direction;
    public float speed = 3f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pointB = target.position;
        Vector2 pointA = rb2d.position;
        Vector2 distance = pointB - pointA;
        if (distance.magnitude<=15)
        {
            direction = distance.normalized;
        }
        else
        {
            direction *= 0;
        }
        if (distance.magnitude<=20)
        {
            if (drone1==null)
            {
                drone1 = Instantiate(shot).GetComponent<Drone>();
                drone1.transform.position = transform.position;
                drone1.target = target;
            }
            if (drone2 == null)
            {
                drone2 = Instantiate(shot).GetComponent<Drone>();
                drone2.transform.position = transform.position;
                drone2.target = target;
            }
            
        }
    }
    private void FixedUpdate()
    {
        Vector2 newPos = rb2d.position + direction * speed * Time.deltaTime;
        rb2d.MovePosition(newPos);
    }
}
