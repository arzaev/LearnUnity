using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacles();
    }

    private void SpawnObstacles()
    {
        for (int i = 0; i < 20; i++)
        {
            var position = new Vector3(Random.Range(1f, 2f), 1, Random.Range(10.0f, 170.0f));
            Instantiate(obstacle, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
