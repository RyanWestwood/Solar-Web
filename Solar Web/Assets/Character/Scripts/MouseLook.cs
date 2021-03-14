using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f; //control the speed of the mouse

    public Transform player; // reference to player object

    float xRotation = 0f; // variable to rotate around x axis

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // allows cursor to not be shown when playing the game and also locks the cursor to the middle of the screen.
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // gets input from mouse movement on the x axis.
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // gets input from mouse movement on the y axis.

        xRotation -= mouseY; // decrease xrotation based on mouse movement on the y axis
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // mathf.clamp allows the user to set min and max rotation of mouse movement.

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //allows rotation in the x axis, Quaternion is responsible for rotation in unity.
        player.Rotate(Vector3.up * mouseX); // player rotates in the x axis when mouse movement on the x axis occurs.
    }
}
