using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCollectables : MonoBehaviour
{
    Text textbox;
    public Inventory pInventory;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = pInventory.collectibles.ToString();
    }
}
