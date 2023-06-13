using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkDemo : MonoBehaviour
{
    public SpriteRenderer sRenderer;
    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            sRenderer.color = Color.blue;
        }
        else
        {
            sRenderer.color = Color.red;
        }
    }
}
