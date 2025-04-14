using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MyBoxMan : MonoBehaviour
{
    public float Speed;
    public float MaxSpeed = 10; // NEW
    public float AddSpeed = 0.01f; 
    public float AddSpeedDefault = 0.01f;
    public float MaxAddSpeed = 10;
    public int Reverse;
    public Vector3 rotateDirection;
    public bool flag; 
    public bool otherDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* // NEW
        if (flag){ 
            Reverse = 0; 
        } 
        else if (otherDir){
            Reverse = 1;
        }
        else { 
            Reverse = -1; 
        } 
        */ // NEW

        Speed = Speed + AddSpeed;

        if (Speed > MaxSpeed) { 
            Speed = MaxSpeed; 
        } 

        if (Input.GetKeyDown("space")){ 
            Reverse = Reverse * -1; 
        } 

        if (Input.GetKey(KeyCode.B)){// NEW
            AddSpeed = MaxAddSpeed; 
        } 
        else { 
            AddSpeed = AddSpeedDefault; 
        } 

        if (Input.GetKeyUp(KeyCode.N)){ // NEW
            Speed = 0; 
        } 

        transform.Rotate(rotateDirection*Speed*Reverse*Time.deltaTime);
    }
}
