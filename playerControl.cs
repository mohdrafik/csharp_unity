using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

    public string inputID;


    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    private float speed = 10.0f;
    private float turnSpeed =30.0f;
    private float horizontalInput;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        // start 
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);
        
        
        // we will move forward the vehicle.
        //transform.Translate(0,0,1);
        // transform.Translate(Vector3.forward);     // this also do the same as above line vector3.forward.
        transform.Translate(Vector3.forward *  Time.deltaTime * speed * verticalInput);
//        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed*horizontalInput);  // here it slides left and right depends on the left and right arrow control keys.
        // we will try to rotate instead of sliding.
         transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*horizontalInput);

        if(Input.GetKeyDown(switchKey))
        {
          mainCamera.enabled = !mainCamera.enabled;
          hoodCamera.enabled = !hoodCamera.enabled;   


        }


        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * verticalInput);
        //transform.Translate(Vector3.left * Time.deltaTime * turnSpeed * horizontalInput);  // if I press left it goes right --> left = -1 


    }
}


