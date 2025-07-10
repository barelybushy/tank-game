using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Making The Controls Private
    private float speed = 15.0f;
  private float turnSpeed = 45.0f;
  private float horizontalInput;
  private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
       forwardInput = Input.GetAxis("Vertical");

        //Move Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Move Vehicle Left and Right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
