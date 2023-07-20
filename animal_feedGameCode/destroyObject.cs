using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    private float zfar = -12.0f;
    private float znear = 35.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.z > znear)||(transform.position.z <  zfar))
        {
            Destroy(gameObject);
        }
    }
}
