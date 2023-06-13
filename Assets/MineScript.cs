using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    public GameObject boom;
    float timer = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<=0)
        {
            Destroy(gameObject);
            GameObject destroyRef = Instantiate(boom);
            destroyRef.transform.position = transform.position;
        }
    }
}
