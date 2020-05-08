using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 camOffset;

    // Update is called once per frame
    void Update()
    {
        //transform refers to transform of the current game object, i.e. whatever this script is attached to
        //in this case, a camera
        transform.position = player.position+camOffset;
    }
}
