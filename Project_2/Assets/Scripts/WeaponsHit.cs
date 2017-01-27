using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsHit : MonoBehaviour
{

    public GameObject manager;
    public bool hit;
    public GameManager plusOne;

    void OnTriggerEnter(Collider other)
    {
        hit = true;
        plusOne.inventory++;
        plusOne.Loop(); 
    }
}
