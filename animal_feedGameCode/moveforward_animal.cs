using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveforward_animal : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);  
    }
}
