using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj)
    {
        if(obj.tag == "Player") FindObjectOfType<GameManager>().Win();
    }
}
