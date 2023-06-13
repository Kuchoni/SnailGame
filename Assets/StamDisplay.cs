using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StamDisplay : MonoBehaviour
{
    public float threshold;
    public Stamina stam;
    public Image image;
    public bool isHp;
    // Start is called before the first frame update
    void Start()
    {
      
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHp) {
            image.enabled = true;
        }
        else if (threshold<stam.stamina)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }
    }
}
