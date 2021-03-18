using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public float width, depth, height;

    private List<Vector3> points = new List<Vector3>( new Vector3[8] );

    // Start is called before the first frame update
    void Start()
    {
        width = 1;
        depth = 1;
        height = 1;

        FunctonGat();
    }

    void FunctonGat()
    {
        points[0] = new Vector3(width / 2, height / 2, depth / 2);
        points[1] = new Vector3(-width / 2, height / 2, depth / 2);
        points[2] = new Vector3(-width / 2, -height / 2, depth / 2);
        points[3] = new Vector3(width / 2, -height / 2, depth / 2);
        points[4] = new Vector3(width / 2, height / 2, -depth / 2);
        points[5] = new Vector3(-width / 2, height / 2, -depth / 2);
        points[6] = new Vector3(-width / 2, -height / 2, -depth / 2);
        points[7] = new Vector3(width / 2, -height / 2, -depth / 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            FunctonGat();
        }
    }
}
