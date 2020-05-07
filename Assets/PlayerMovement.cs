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
        //playerRb.useGravity = false;

        //Applies an initial force
        //playerRb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void Update()
    {
        //So issue, this is called every frame, but if someone has a higher frame right, that person's box will move faster!
        //playerRb.AddForce(0, 0, 200);

        //So we add this thingy, which is basically how much time passes in between each frame, so it is smaller for higher frame rates and balances everything out
        playerRb.AddForce(0,0,2000*Time.deltaTime);
    }
}
