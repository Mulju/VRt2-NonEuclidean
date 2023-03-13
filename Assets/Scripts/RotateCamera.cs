using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    
    private float sensitivity = 2500f;
    private float xRotation, mouseX, mouseY;

    void Start()
    {
        // Lukitsee kursorin pelin‰kym‰‰n
        Cursor.lockState = CursorLockMode.Locked;
        xRotation = 0f;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
