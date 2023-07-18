using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject Player;
    private Vector3 offset = new Vector3(0, 6, -6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       
        transform.position = Player.transform.position + offset;
        //this is for the offset of the camera
        /* 
         here player.transform.position --> vehicle.transform.position 
         because in the componant of the main camera we defined the player --> vehicle. player sit in vehicle.
         so vehicle position + shift (vector3(-0.20,5.78,-5.96))--> this should be the camera position.
                         
         */



    }
}

