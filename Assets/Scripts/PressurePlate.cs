﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject Box;
    public bool BoxBroken = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Box")
        {
            Destroy(collision.gameObject);
            BoxBroken = true;
        }

    }
}
