using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3((float)(-0.2), (float)(5.78), (float)(-5.96));
        /* here player.transform.position --> vehicle.transform.position 
         because in the componant of the main camera we defined the player --> vehicle. player sit in vehicle.
        so vehicle position + shift (vector3(-0.20,5.78,-5.96))--> this should be the camera position.
          
         
         
         */
    }
}

