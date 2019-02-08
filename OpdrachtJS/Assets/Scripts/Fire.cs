using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    private ControlFire fire;
    private UserData stats;

    private void Awake()
    {
        stats = GetComponent<UserData>();
        fire = GetComponent<ControlFire>();
        fire.FireBullet += Shoot;
    }

    

    private void Shoot()
    {
        stats.hp -= 1;
        Debug.Log("shots are fired and you have " + stats.hp + " HP.");
    }
}
