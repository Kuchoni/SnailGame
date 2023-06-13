using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int collectibles;
    public GameOverOnCollision life;

    void Update() {
        if (collectibles>=5) {
            collectibles-=5;
            life.health++;
        }
    }
}
