using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr : MonoBehaviour
{
    Rigidbody ourRigidBody;

    float speed = 10f;
    float rotationSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {
        ourRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ourRigidBody.AddExplosionForce(1000, transform.position + Vector3.down + Vector3.back, 1);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 0.5f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, 0.5f);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}
