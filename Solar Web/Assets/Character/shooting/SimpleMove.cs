using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    private float speed = 75f;
    private float time = 0F;

    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        time += Time.deltaTime;
        if (time > 5) Destroy(this.gameObject);
    }
}
