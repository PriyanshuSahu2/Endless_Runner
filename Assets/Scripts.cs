using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    public float speed;
    public Camera cam;
    private Rigidbody rb;
    public float jumpForce =8f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiX = Input.GetAxis("Horizontal");
        transform.position += Vector3.forward * speed*Time.deltaTime;
        cam.transform.position += Vector3.forward * speed * Time.deltaTime;
        transform.position += Vector3.right * speed *horiX* Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("KMM");
            rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
        }
    }
}
