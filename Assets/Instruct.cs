using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruct : MonoBehaviour
{
    public PlayerMovement mvmt;
    public int JumpBuildId;
    public int MoveBuildId;
    public GameObject instructUIObj;
   
    // Start is called before the first frame update
    void Start()
    {
        int curId = SceneManager.GetActiveScene().buildIndex;
        if(curId == JumpBuildId || curId == MoveBuildId)
        {
            mvmt.enabled = false; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        int curId = SceneManager.GetActiveScene().buildIndex;

        if ((Input.GetKey("a") || Input.GetKey("d")) && curId == MoveBuildId)
        {
            mvmt.enabled = true;
            instructUIObj.SetActive(false);
        }

        if (Input.GetKeyDown("w") && curId == JumpBuildId)
        {
            mvmt.enabled = true;
            instructUIObj.SetActive(false);
        }
    }
}
