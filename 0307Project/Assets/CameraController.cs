using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public Transform target_1;
    public Transform target_2;
    public Transform target_3;
    public bool lookAtok; //new
    public float speed = 1;
    public float speed_rotate = 10;
    public float addSpeed = 10;
    public float slowSpeed = 1;
    public float addSpeed_rotate = 20;
    public float slowSpeed_rotate = 10;
    private @Player player;
    public Transform Camera_Pos1;
    public Transform Camera_Pos2;
    public Transform Camera_Pos3;

    void OnEnable()
    {
        player = new @Player();
        player.Enable();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.main.forward.IsPressed()){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if (player.main.back.IsPressed()){
            transform.Translate(Vector3.forward*-1*speed*Time.deltaTime);
        }
        if (player.main.left.IsPressed()){
            transform.Translate(Vector3.right*-1*speed*Time.deltaTime);
        }
        if (player.main.right.IsPressed()){
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if (player.main.up.IsPressed()){
            transform.Translate(Vector3.up*speed*Time.deltaTime);
        }
        if (player.main.down.IsPressed()){
            transform.Translate(Vector3.up*-1*speed*Time.deltaTime);
        }
        

        if (player.main.rotateLeft.IsPressed()){
            transform.Rotate(Vector3.up*speed_rotate*Time.deltaTime);
        }
        if (player.main.rotateRight.IsPressed()){
            transform.Rotate(Vector3.up*-1*speed_rotate*Time.deltaTime);
        }
        if (player.main.rotateUp.IsPressed()){
            transform.Rotate(Vector3.forward*speed_rotate*Time.deltaTime);
        }
        if (player.main.rotateDown.IsPressed()){
            transform.Rotate(Vector3.forward*-1*speed_rotate*Time.deltaTime);
        }

        if (player.main.originalCam.IsPressed()){
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            lookAtok = false;//NEW
        }

        if (player.main.AddSpeed.IsPressed()){
            speed = addSpeed;
            speed_rotate = addSpeed_rotate; 
        }
        else {
            speed = slowSpeed;
            speed_rotate = slowSpeed_rotate;
        }

        if (player.main.cam1.IsPressed()){
            transform.position = Camera_Pos1.transform.position;
            target = target_1;
            lookAtok = true;//NEW
        }
        if (player.main.cam2.IsPressed()){
            transform.position = Camera_Pos2.transform.position;
            target = target_2;
            lookAtok = true;//NEW
        }
        if (player.main.cam3.IsPressed()){
            transform.position = Camera_Pos3.transform.position;
            target = target_3;
            lookAtok = true;//NEW
        }

        if(lookAtok){
            transform.LookAt(target);//NEW
        }
        else {

        }
        
        
    }
}
