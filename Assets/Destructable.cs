using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{
    public int health = 3;
    public bool spawnThing;
    public GameObject thing;
    
    public void Damage(int amount)
    {
        health -= amount; 
        if (health<=0)
        {
            Destroy(gameObject);
            if (spawnThing)
            {
                GameObject destroyRef = Instantiate(thing);
                destroyRef.transform.position = transform.position;
            }
        }
    }
}
