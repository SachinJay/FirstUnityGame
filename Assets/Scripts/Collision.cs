using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    public PlayerMovement mvmt;

    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        Debug.Log(collision.collider.name);
        
        if(collision.collider.tag == "Obstacle")
        {
            //When you collide with an obstacle, stop the player from moving
            mvmt.enabled = false;

            FindObjectOfType<GameManager>().GameOver();
            //IDEA: I saw an add explosion force, so I think maybe we should explode the player on contact that'd be neat
        }
    }
}
