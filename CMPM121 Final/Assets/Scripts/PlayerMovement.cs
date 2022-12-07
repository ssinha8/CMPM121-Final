using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f; 
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        float zMove = Input.GetAxis("Vertical");
        Vector3 force = new Vector3(0.0f, 0.0f, zMove);

        rb.AddRelativeForce(force);

        if (Input.GetKeyDown(KeyCode.A)) {
            transform.Rotate(0, -90.0f, 0, Space.Self);
        }
        else if (Input.GetKeyDown(KeyCode.D)) {
            transform.Rotate(0, 90.0f, 0, Space.Self);
        }

    }
}
