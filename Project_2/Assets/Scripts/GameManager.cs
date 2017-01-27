using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> weapons = new List<GameObject>();
    public List<GameObject> equipped = new List<GameObject>();
    public List<bool> pickedUp = new List<bool>();
    public GameObject lanternLight;
    public GameObject lightSource;
    public int inventory;

    public void Start()
    {
        lightSource.GetComponent<Light>().intensity = 0;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Loop()
    {
        print("Pick up");
        for (int i = 0; i < weapons.Count; i++)
        {
            if (weapons[i].GetComponent<WeaponsHit>().hit == true)
            {
                weapons[i].GetComponent<MeshRenderer>().enabled = false;
                weapons[i].GetComponent<BoxCollider>().enabled = false;
                equipped[i].GetComponent<MeshRenderer>().enabled = true;
            }

        for (int pickUp = 0; pickUp < pickedUp.Count; pickUp++)
            {
                pickedUp[inventory] = true;
            }
        }
    }
    public void Update()
    {
        if (lanternLight.GetComponent<MeshRenderer>().enabled == true)
        {
            lightSource.GetComponent<Light>().intensity = 2;
        }
        if (Input.GetButton("Cancel"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (pickedUp[1] == true)
        {
            Application.Quit();
        }
    }
}
