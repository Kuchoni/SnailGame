using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHP : MonoBehaviour
{
    Text textbox;
    public GameOverOnCollision pHP;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = pHP.health.ToString();
    }
}
