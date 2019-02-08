using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFire : MonoBehaviour {

    public Action<string> FireBullet;

    private void Awake()
    {
        FireBullet("Shots have been fired!");
    }


}
