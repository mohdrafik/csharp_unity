using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class farmer_move : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 40.0f;
    private float horizontalInput;
    private float horizontalKeycorrection = -1.0f;
    private float farmer_boundX = 10.0f;
    public GameObject projectilePrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
        {
            // we can write in this way also : Input.GetKeyDown(KeyCode.space)
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);  // instantiate creat the new object and also clone the previous created object also 
                                                                                                     // for example here projectilePrefab is already created object and we are cloning. 

        }
    
           

        horizontalInput = UnityEngine.Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalKeycorrection* horizontalInput * speed);
        if (transform.position.x > farmer_boundX)
            transform.position = new Vector3(farmer_boundX, transform.position.y, transform.position.z);
            //transform.position = new vector3(farmer_boundx, 0, 30);
        if (transform.position.x < -farmer_boundX)
            //transform.position = Vector3.zero; this will bring the player at globally the zero position 
            transform.position = new Vector3(-farmer_boundX, transform.position.y, transform.position.z);
    }
}
