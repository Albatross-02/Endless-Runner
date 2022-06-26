using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    Player PlayerMovement;
    // Start is called before the first frame update
    private void Start()
    {
        PlayerMovement = GameObject.FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Kill the player
            PlayerMovement.Die();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
