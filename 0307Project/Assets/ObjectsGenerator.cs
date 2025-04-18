using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

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
    public GameObject [] prefabs;
    public Transform placement;
    public float drift = 2.2f;

    public float timer;
    public float interval;
    public float spawnTime;
    public int PrefabIndex =0 ;
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
                    Instantiate(prefabs[0], placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
                }
            }
        }
        if(Input.GetKey(KeyCode.J))
        {
            if(timer>spawnTime){
                for (int n=0; n<=prefabs.Length-1;n++){
                    Instantiate(prefabs[n], placement.position, Quaternion.identity);
                    Debug.Log("陣列長度"+prefabs.Length);
                }
                spawnTime = timer+interval;
            }
        }
        if(Input.GetKeyUp(KeyCode.J))
        {
            Instantiate(prefabs[2], placement.position, Quaternion.identity);
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            for (int x = -5; x < 5; x++){
                for (int z = -5; z < 5; z++){
                    drift = Random.Range(1, 6);
                    Instantiate(prefabs[3], placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
                }
            }
        }
        if(Input.GetKey(KeyCode.K))
        {
            if(timer>spawnTime){
                
                Instantiate(prefabs[PrefabIndex], placement.position, Quaternion.identity);
                PrefabIndex ++;
                if(PrefabIndex >prefabs.Length-1){
                    PrefabIndex=0;
                }
                spawnTime = timer+interval;
            }
        }
        if(Input.GetKeyUp(KeyCode.K))
        {
            Instantiate(prefabs[5], placement.position, Quaternion.identity);
        }

    }
}
