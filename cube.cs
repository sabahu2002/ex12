using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{

    public float horizontalSpeed = 1f;
    public float verticalSpeed = 1f;
    void Update()
    {
        Move(transform, horizontalSpeed, verticalSpeed);
    }

    void Move(Transform obj, float horizontalSpeed, float verticalSpeed)
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput * horizontalSpeed, verticalInput * verticalSpeed, 0);

        obj.position += movement * Time.deltaTime;
    }
}
