using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacles : MonoBehaviour
{

    private Vector3 pos = new Vector3(0, 5, -7);
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        GameObject a = Instantiate(obstacle, pos, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
