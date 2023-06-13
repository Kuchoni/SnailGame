using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    public float stamina = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        stamina += 500f*Time.deltaTime;
        if (stamina > 1000.5)
            stamina = 1000.5f;
    }
}
