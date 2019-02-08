using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFire : MonoBehaviour {

    public Action FireBullet;

    private void Awake()
    {
        //FireBullet();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }
}
