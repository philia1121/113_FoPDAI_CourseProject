using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class happyhappy : MonoBehaviour
{
    Happyinput happy;

    void OnEnable()
    {
        happy = new Happyinput();
        happy.Enable();

        happy.camera.Jump.started += jumping;
    }

    void jumping(InputAction.CallbackContext ctx)
    {
        this.transform.Rotate(new Vector3(0f,90f,0f));
    }
}
