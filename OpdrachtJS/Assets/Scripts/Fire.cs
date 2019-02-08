using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    private void Awake()
    {
        ControlFire fire = GetComponent<ControlFire>();
        fire.FireBullet += Shoot;
    }

    private void Shoot(string msg)
    {
        Debug.Log(msg);
    }
}
