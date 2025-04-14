using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    public Transform Camera_Pos1;
    public Transform Camera_Pos2;
    public Transform Camera_Pos3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.forward*-1*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.right*-1*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R)){
            transform.Translate(Vector3.up*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F)){
            transform.Translate(Vector3.up*-1*speed*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q)){
            transform.Rotate(Vector3.up*speed_rotate*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)){
            transform.Rotate(Vector3.up*-1*speed_rotate*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Z)){
            transform.Rotate(Vector3.forward*speed_rotate*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.C)){
            transform.Rotate(Vector3.forward*-1*speed_rotate*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.X)){
            transform.position = Vector3.zero;
            transform.rotation = Quaternion.identity;
            lookAtok = false;//NEW
        }

        if (Input.GetKey(KeyCode.V)){
            speed = addSpeed;
            speed_rotate = addSpeed_rotate; 
        }
        else {
            speed = slowSpeed;
            speed_rotate = slowSpeed_rotate;
        }

        if (Input.GetKey(KeyCode.Alpha1)){
            transform.position = Camera_Pos1.transform.position;
            target = target_1;
            lookAtok = true;//NEW
        }
        if (Input.GetKey(KeyCode.Alpha2)){
            transform.position = Camera_Pos2.transform.position;
            target = target_2;
            lookAtok = true;//NEW
        }
        if (Input.GetKey(KeyCode.Alpha3)){
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
