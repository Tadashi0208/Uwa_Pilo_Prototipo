using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public float mouseSensytivityX = 150;
    public float mouseSensytivityY = 150;
    public float walkSpeed;

    float verticalLookRotation;

    Transform cameraT;
    Rigidbody rbT;

    Vector3 moveAmount;
    Vector3 smoothMoveVelocity;
    void Start()
    {
        cameraT=Camera.main.transform;
        rbT=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensytivityX);
        verticalLookRotation += Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensytivityY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -60, 60);
        cameraT.localEulerAngles = Vector3.left * verticalLookRotation;

        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical")).normalized;
        Vector3 targetMoveAmount=moveDir*walkSpeed;
        moveAmount = Vector3.SmoothDamp(moveAmount,targetMoveAmount,ref smoothMoveVelocity,.15f);
    }

    private void FixedUpdate()
    {
        rbT.MovePosition(rbT.position + transform.TransformDirection(moveAmount)*Time.fixedDeltaTime);
    }
}
