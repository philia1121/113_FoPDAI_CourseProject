using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObjectsGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject prefabA;
    public GameObject prefabB;
    public GameObject prefabC;
    public GameObject prefabD;
    public GameObject prefabE;
    public GameObject prefabF;
    public Transform placement;
    public float drift = 2.2f;

    public float timer;
    public float interval;
    public float spawnTime;
    void Start()
    {
        for (int num = 0; num < 5; num++){
            Instantiate(prefab, placement.position + new Vector3 (0, num*drift, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
        if(Input.GetKeyDown(KeyCode.J))
        {
            for (int x = -5; x < 5; x++){
                for (int z = -5; z < 5; z++){
                    drift = Random.Range(1, 6);
                    Instantiate(prefabA, placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
                }
            }
        }
        if(Input.GetKey(KeyCode.J))
        {
            if(timer>spawnTime){
                Instantiate(prefabB, placement.position, Quaternion.identity);
                spawnTime = timer+interval;
            }
        }
        if(Input.GetKeyUp(KeyCode.J))
        {
            Instantiate(prefabC, placement.position, Quaternion.identity);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            for (int x = -5; x < 5; x++){
                for (int z = -5; z < 5; z++){
                    drift = Random.Range(1, 6);
                    Instantiate(prefabD, placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
                }
            }
        }
        if(Input.GetKey(KeyCode.K))
        {
            if(timer>spawnTime){
                Instantiate(prefabE, placement.position, Quaternion.identity);
                spawnTime = timer+interval;
            }
        }
        if(Input.GetKeyUp(KeyCode.K))
        {
            Instantiate(prefabF, placement.position, Quaternion.identity);
        }

    }
}
