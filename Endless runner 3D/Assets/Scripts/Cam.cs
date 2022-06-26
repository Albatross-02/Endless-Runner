using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Player;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetpos = Player.position + offset;
        targetpos.x = 0;
        transform.position = targetpos;
    }
}
