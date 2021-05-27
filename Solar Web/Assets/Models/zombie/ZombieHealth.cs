using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            //Destroy(other.gameObject);
            //LoseHealth(100);
            //ui.DisplayScoreAnimation();
        }
    }
}
