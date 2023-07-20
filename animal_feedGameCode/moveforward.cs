using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class moveforward : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 40.0f;
    private float towardsAnimal = -1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * towardsAnimal*speed);            
        //transform.position.GameObject 

    }
}
