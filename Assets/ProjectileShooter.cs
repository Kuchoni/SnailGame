using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Stamina stam;
    // Start is called before the first frame update
    void Start()
    {
        stam = GetComponent<Stamina>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&stam.stamina>=500)
        {
            Projectile projectileInstance = Instantiate(projectilePrefab).GetComponent<Projectile>();
            projectileInstance.transform.position = transform.position;
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos = projectileInstance.transform.position;
            Vector2 direction = (cursorPos-pos).normalized;
            projectileInstance.direction = direction;
            
            stam.stamina -= 500;
        }
            
    }
}
