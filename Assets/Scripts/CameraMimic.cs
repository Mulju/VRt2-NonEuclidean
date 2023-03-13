using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMimic : MonoBehaviour
{
    [SerializeField]
    private Transform playerCamera;

    [SerializeField]
    private Transform screen1;

    [SerializeField]
    private Transform screen2;

    private Vector3 playerOffset, newDirection;
    private float angleOffset;
    Quaternion rotationDiff;

    private void LateUpdate()
    {
        // Siirret‰‰n "kopio" kamera samalla tavalla kuin player camera
        playerOffset = playerCamera.position - screen1.position;
        transform.position = screen2.position + playerOffset;

        // Rotaatioiden ero
        angleOffset = Quaternion.Angle(screen2.rotation, screen1.rotation);

        // Pyˆr‰hdys y-akselin ymp‰ri
        rotationDiff = Quaternion.AngleAxis(angleOffset, Vector3.up);

        // K‰‰nt‰‰ kameran samalla tavalla kuin pelaajan kamera
        newDirection = rotationDiff * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newDirection, Vector3.up);
    }
}
