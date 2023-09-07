using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float sensitivityX = 2F;
    public float sensitivityY = 2F;
    public float minimumY = -90F;
    public float maximumY = 90F;
    float rotationY = -60F;
    
    // For camera movement
    float CameraPanningSpeed = 10.0f;

    // Start is called before the first frame update
    void Start() {
        HideAndLockCursor();
    }
    
    // Update is called once per frame
    void Update()
    {
        MouseMove();
    }

    void HideAndLockCursor() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void MouseMove()
    {
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        //rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
