﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myConstantRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 1, 0 * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
