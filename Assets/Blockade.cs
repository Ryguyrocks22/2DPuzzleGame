using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockade : MonoBehaviour
{
    public GameObject box;
    

    private void Start()
    {
        
        
        if (PressurePlate.BoxBroken == true)
        {
            Destroy(gameObject);
        }
    }
}
