﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emeny_Script : MonoBehaviour
{
    private float z_trans;
    private float current_z_trans;

    // Start is called before the first frame update
    void Start()
    {
        current_z_trans = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float pos_result;

        z_trans -= 0.001f;
        pos_result = current_z_trans + z_trans;
        transform.Translate(0.0f, 0.0f, z_trans);

        Debug.Log(z_trans);

        if(transform.position.z < -15.0f)
        {
            Destroy(gameObject, 0);
        }
    }
}
