using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    //Stuff n things
    public int hitPoints = 5;
    public float speed = 4.5f;
    public string name = "Jimothy";
    public bool hasGlasses = false;

    public Color color = Color.blue;
    public Vector2 position;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Hello Starting");
        hitPoints += 5;
        hitPoints -= 5;
        hitPoints *= 5;
        hitPoints /= 5;
        Debug.Log("I am " + name);

        if (hasGlasses == true )
        {
            Debug.Log("aight");
        }else
        {
            Debug.Log("aighter");
        }
        direction.x = 0;
        direction.y = 1;

        direction = new Vector2(0, 1);

        direction = Vector2.up;

        color = new Color(1, 2, 3);
    }

    // Update is called once per frame
    void Update() {
        
    }
}
