using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Can instantiate anything like this
    //Then, in unity, can drag the particular component you want to access into the corresopnding field
    public Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        //When you write to the log, it shows up when you play the game under the Console panel
        //Debug.Log("Hello, World");

        //Turns off gravity for the player cube
        playerRb.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
