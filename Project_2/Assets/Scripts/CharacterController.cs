﻿using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{

    public float speed;
    public float jumpspeed;
    public bool jumppushed;
    public float timer;

	void Update ()
    {
        float vertical = Input.GetAxis("Vertical") * speed;
        float horizontal = Input.GetAxis("Horizontal") * speed;
        vertical *= Time.deltaTime;
        horizontal *= Time.deltaTime;

        transform.Translate(horizontal, 0, vertical);

        if (Input.GetButtonDown("Jump") && jumppushed == false)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpspeed);
            jumppushed = true;
        }
        if (jumppushed == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (jumppushed == true && timer > 1)
        {
            timer = 0;
            jumppushed = false;
        }
    }
}
