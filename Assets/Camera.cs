using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    void Update()
    {
        // float mouseInput = Input.GetAxis("Mouse X");
        // Vector3 lookhere = new Vector3(0, mouseInput, 0);
        //transform.Rotate(lookhere);

        
        float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
        float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
        transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }
    void LateUpdate()
    {
        transform.position = target.position;
    }
}
