using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    public GameObject player;
    public GameObject checkpoint;

    private void OnTriggerEnter(Collider other)
    {             
        Debug.Log("Hello World");

        player.transform.position = checkpoint.transform.position;


    }

}
