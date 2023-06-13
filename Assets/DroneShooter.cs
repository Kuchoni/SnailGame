using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneShooter : MonoBehaviour
{
    public GameObject shot;
    public Rigidbody2D target;
    public int droneCount;
    private Drone drone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (drone == null)
        {
            droneCount = 0;
        }
        Vector2 pos = transform.position;
        if ((target.position-pos).magnitude<10&&droneCount==0)
        {
            drone = Instantiate(shot).GetComponent<Drone>();
            drone.transform.position = transform.position;
            drone.target = target;
            droneCount++;
        }
    }
}
