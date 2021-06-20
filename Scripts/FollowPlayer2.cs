using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool firstView = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (firstView)
            {
                offset = new Vector3(0, 5, -7);
                firstView = false;
            }
            else
            {
                offset = new Vector3(0, 2, 1);
                firstView = true;
            }
        }
    }
}
