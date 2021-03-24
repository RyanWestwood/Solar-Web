using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController controller; //reference to character controller
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public Animator anim; //reference to animator

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("condition", 1); //if W key is pressed then the condition changes from 0 to 1 and the character will move forward in world space whilst the walk animation is played.
            transform.position += transform.forward * walkSpeed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("condition", 0); //if W is no longer being pressed then the idle animation plays.
        }

        if (Input.GetKey(KeyCode.Q))
        {
            anim.SetInteger("condition", 2); //if W key is pressed then the condition changes from 0 to 2 and the character will run forward in world space whilst the run animation is played.
            transform.position += transform.forward * runSpeed * Time.deltaTime;

        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            anim.SetInteger("condition", 0); //if Q is no longer being pressed then the idle animation plays.
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetInteger("condition", 3);  //if space key is pressed then the condition changes from 0 to 3 and the character will jump. note: will have to hold space key for the full jump animation to play out.
            //GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
        }
      //  if (Input.GetKeyUp(KeyCode.Space))
     //   {
     //       anim.SetInteger("condition", 0); //if space key is no longer being pressed then the idle animation plays.
   //     }

    }
}
