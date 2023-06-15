using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{

    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        // start 
    }

    // Update is called once per frame
    void Update()
    {
        // we will move forward the vehicle.
        //transform.Translate(0,0,1);
        // transform.Translate(Vector3.forward);     // this also do the same as above line vector3.forward.
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

    }
}
