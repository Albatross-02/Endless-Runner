using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    public GameObject groundtile;
    Vector3 nextSpawnPoint;

    public void SpawnTile(bool Spawnobstacles)
    {
        GameObject temp = Instantiate(groundtile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if (Spawnobstacles)
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            if (i < 3)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
