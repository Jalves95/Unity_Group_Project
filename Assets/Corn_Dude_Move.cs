using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class Corn_Dude_Move : MonoBehaviour
{
    public Animator anim;
    public Camera cam;

    private float speed = 9f, camSensitivity = 100f;
    private Vector3 movement;

    /*void Start()
    {
        
    }*/

    void Update()
    {
        float moveH = Input.GetAxisRaw("Horizontal");
        float moveV = Input.GetAxisRaw("Vertical");

        movement = new Vector3(moveH, 0f, moveV);
        movement = transform.TransformDirection(movement.normalized * Time.deltaTime * speed);
        transform.position += movement;

        float camX = Input.GetAxis("Mouse X") * camSensitivity * Time.deltaTime;
        Vector3 rotate = new Vector3(0, camX, 0);
        transform.Rotate(rotate);

        if (moveH != 0 || moveV != 0)
        {
            anim.SetBool("Running", true);
            anim.SetBool("Excited", false);
        }
        else
        {
            anim.SetBool("Running", false);
            anim.SetBool("Excited", true);
        }
    }
}
