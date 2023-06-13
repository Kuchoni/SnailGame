using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{
    public int health;
    public int invinc;
    public SpriteRenderer render;
    private void Start()
    {
        health = 3;
        invinc = 10;
        render = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (invinc > 0)
        {
            render.color = Color.gray;
            invinc--;
        }
        else
            render.color = Color.white;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EProj") && invinc == 0) {
            health--;
        invinc += 250;
    }
        if (health == 0)
            SceneManager.LoadScene("Game Over");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "Enemy"||collision.gameObject.tag == "EProj") && invinc == 0)
        {
            health--;
            invinc += 250;
        }
        if (health == 0)
            SceneManager.LoadScene("Game Over");
    }
}
