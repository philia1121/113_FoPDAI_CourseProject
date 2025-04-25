using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    // Start is called before the first frame update
    public int count;
    public int MaxCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject, 1.1f);
        count++;//count=count=1;

        if (count>MaxCount&&Time.time>10f){
            Destroy(gameObject);
        }

    }
}
