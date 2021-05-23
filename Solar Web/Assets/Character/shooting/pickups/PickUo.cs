using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUo : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerOne")
        {
            Destroy(other.gameObject);
        }
    }
}
