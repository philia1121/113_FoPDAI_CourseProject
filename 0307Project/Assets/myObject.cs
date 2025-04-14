using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myObject : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
    void Start()
    {
        Destroy(gameObject, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
