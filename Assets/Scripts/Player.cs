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
    
    public GameObject Bullet;
    public float FireRate = 0.2f;
    private float _lastFireTime = 0f;

    // Start is called before the first frame update
    void Start() {
        
    }
    
    // Update is called once per frame
    void Update() {
        
    }

    void MouseInput() {
        MouseMove();
        if (Input.GetMouseButton(0)) {
        //if (true) {
            if (Time.time - _lastFireTime >= FireRate) {
                Rigidbody bullet = Instantiate(Bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
                Quaternion cameraRotation = Quaternion.Euler(transform.eulerAngles);
                bullet.velocity = cameraRotation * Vector3.forward * 10;
                _lastFireTime = Time.time;
            }
        }
    }

    void HideAndLockCursor() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void MouseMove()
    {
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
