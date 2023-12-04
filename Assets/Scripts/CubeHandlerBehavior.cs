using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    public float rotationSpeed = 30f;
    private bool rotate = true;
    void Update()
    {
        // Check if the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            rotate = !rotate;
        }
        if (rotate)
        {
            // Rotate the cube around its up (Y) axis
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}