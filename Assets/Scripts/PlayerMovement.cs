﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    //Can instantiate anything like this
    //Then, in unity, can drag the particular component you want to access into the corresopnding field
    public Rigidbody playerRb;

    public float playerForce = 2000f;
    public float sideForce = 500f;
    private bool isRight = false;
    private bool isLeft = false;
    public float jumpForce;
    public int jumpUnlockBuildId;
    private bool jumpUnlocked = false;
    public AudioSource audSrc;

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

    private void Update()
    {
        isRight = Input.GetKey("d");
        isLeft = Input.GetKey("a");
        jumpUnlocked = SceneManager.GetActiveScene().buildIndex >= jumpUnlockBuildId;

        if(Input.GetKeyDown("w") && playerRb.position.y < 1.1f  && playerRb.position.y > 0 && jumpUnlocked)
        {
            print(jumpUnlockBuildId);
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            print("boing");
            audSrc.Play();
        }
    }

    // Update is called once per frame
    //Changed this to FixedUpdate because it is better for physics objects
    void FixedUpdate()
    {
        //So issue, this is called every frame, but if someone has a higher frame right, that person's box will move faster!
        //playerRb.AddForce(0, 0, 200);

        //So we add this thingy, which is basically how much time passes in between each frame, so it is smaller for higher frame rates and balances everything out
        playerRb.AddForce(0,0, playerForce * Time.deltaTime);

        //Adding the cases for wasd inputs 

        if(isRight)
        {
            playerRb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(isLeft)
        {
            playerRb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(playerRb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
