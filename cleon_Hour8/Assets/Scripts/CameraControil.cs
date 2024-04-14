using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControil : MonoBehaviour
{
    public float sensitivity = 5.0f;
    public float moveSpeed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * moveSpeed* Time.deltaTime;

        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

       transform.eulerAngles += new Vector3(-myVal * sensitivity, mxVal * sensitivity, 0);
        
    }
}
