using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Transform playerCam = null;
    [SerializeField] float camSensitivity = 3.5f;
    [SerializeField] float movementMultiplier = 2.5f;

    [SerializeField] float jumpMultiplier = 1.0f;    
    [SerializeField] bool isSprinting = false;
    [SerializeField] bool canJump = false;
    [SerializeField] bool playerActive = true;
    [SerializeField] float gravity = -15.0f;

    [SerializeField] float fallSpeed = 0.0f;
    float camAngle = 0.0f;
    [SerializeField] bool consumeMouse = true;

    CharacterController controller = null;

    [SerializeField][Range(0.0f, 0.5f)] float moveSmoothly = 0.3f;
    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;

    [SerializeField][Range(0.0f, 0.05f)] float lookSmoothly = 0.01f;
    Vector2 currentCamLook = Vector2.zero;
    Vector2 currentCamLookVelocity = Vector2.zero;



    void Start()
    {
        controller = GetComponent<CharacterController>();
        EatMouse(consumeMouse);
    }

 
    void Update()
    {
        if (playerActive){
        //not in menu/paused
        CameraControlUpdate();
        MovementControlUpdate();

        //RESPAWN
        if(transform.position.y < -50){
            transform.position = new Vector3(0,0,0);
        }

        }
        //consumeMouse = false;
        //EatMouse(consumeMouse)

    }
    void MovementControlUpdate(){
        //Updates movement according to input
        Vector2 playerMoveTo = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        playerMoveTo.Normalize();

        currentDir = Vector2.SmoothDamp(currentDir, playerMoveTo, ref currentDirVelocity , moveSmoothly); 

        //Grounded Check
        if(controller.isGrounded){
            fallSpeed = 0;
            canJump = true;
        }else if (!controller.isGrounded){
            canJump = false;
        }

        fallSpeed += gravity * Time.deltaTime;
        
            if(canJump && Input.GetKeyUp(KeyCode.Space)){//JUMP
                fallSpeed = fallSpeed + 5 * jumpMultiplier;
            }      


   
            if(canJump && Input.GetKeyDown(KeyCode.LeftShift)){//SPRINT
                movementMultiplier = 5.0f;
                isSprinting = true;
            } else if(Input.GetKeyUp(KeyCode.LeftShift)){
                movementMultiplier = 2.5f;
                isSprinting = false;
            }        
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * movementMultiplier + Vector3.up * fallSpeed;
        controller.Move(velocity*Time.deltaTime);

    }

    void CameraControlUpdate()
    {
        //Updates cam according to input
        Vector2 mouseMoveTo = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        currentCamLook = Vector2.SmoothDamp(currentCamLook , mouseMoveTo, ref currentCamLookVelocity, lookSmoothly);
        camAngle -= currentCamLook.y * camSensitivity;
        camAngle = Mathf.Clamp(camAngle, -90.0f, 90.0f);
        playerCam.localEulerAngles = Vector3.right * camAngle;
        transform.Rotate(Vector3.up * currentCamLook.x * camSensitivity);        
    }

    void EatMouse(bool value){
        //Lock and hides the mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


}
