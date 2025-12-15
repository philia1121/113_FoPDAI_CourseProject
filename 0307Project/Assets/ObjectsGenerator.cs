using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

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
    public ParticleSystem fireworks;//new
    public float drift = 2.2f;

    public float timer;
    public float interval;
    public float spawnTime;
    public int PrefabIndex =0 ;

    private @Player player;

    void OnEnable()
    {
        player = new @Player();
        player.Enable();

        player.main.GenerateJ.started += Jstart;
        player.main.GenerateJ.performed += Jperform;
        player.main.GenerateJ.canceled += Jcancel;
        player.main.GenerateK.started += Kstart;
        player.main.GenerateK.performed += Kperform;
        player.main.GenerateK.canceled += Kcancel;
        player.main.Firework.performed += fireworkPlay;
        player.main.FireworkColor.performed += color;

    void color(InputAction.CallbackContext ctx)
        {
            Color newcolor = Color.HSVToRGB(ctx.ReadValue<float>(), 1, 1);
            var main = fireworks.main;
            main.startColor = newcolor;
    }

    void fireworkPlay(InputAction.CallbackContext ctx)
    {
            fireworks.Play();    
    }

    void Kstart(InputAction.CallbackContext ctx)
    {
            for (int x = -5; x < 5; x++){
                for (int z = -5; z < 5; z++){
                    drift = Random.Range(1, 6);
                    Instantiate(prefabs[3], placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
                }
            }
    }
    void Kperform(InputAction.CallbackContext ctx)
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
    void Kcancel(InputAction.CallbackContext ctx)
    {
        Instantiate(prefabs[5], placement.position, Quaternion.identity);
    }

    void Jstart(InputAction.CallbackContext ctx){
        for (int x = -5; x < 5; x++){
                for (int z = -5; z < 5; z++){
                    drift = Random.Range(1, 6);
                    Instantiate(prefabs[0], placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
                }
            }
    }

    void Jperform(InputAction.CallbackContext ctx){
            Debug.Log(ctx.ReadValue<float>());
        if (timer > spawnTime)
            {
                for (int n = 0; n <= prefabs.Length - 1; n++)
                {
                    Instantiate(prefabs[n], placement.position, Quaternion.identity);
                    Debug.Log("陣列長度" + prefabs.Length);
                }
                spawnTime = timer + interval;
            }
    }

    void Jcancel(InputAction.CallbackContext ctx){
        Instantiate(prefabs[2], placement.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.time;
    //     if(Input.GetKeyDown(KeyCode.J))
    //     {
    //         for (int x = -5; x < 5; x++){
    //             for (int z = -5; z < 5; z++){
    //                 drift = Random.Range(1, 6);
    //                 Instantiate(prefabs[0], placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
    //             }
    //         }
    //     }
    //     if(Input.GetKey(KeyCode.J))
    //     {
    //         if(timer>spawnTime){
    //             for (int n=0; n<=prefabs.Length-1;n++){
    //                 Instantiate(prefabs[n], placement.position, Quaternion.identity);
    //                 Debug.Log("陣列長度"+prefabs.Length);
    //             }
    //             spawnTime = timer+interval;
    //         }
    //     }
    //     if(Input.GetKeyUp(KeyCode.J))
    //     {
    //         Instantiate(prefabs[2], placement.position, Quaternion.identity);
    //     }

    //     if(Input.GetKeyDown(KeyCode.K))
    //     {
    //         for (int x = -5; x < 5; x++){
    //             for (int z = -5; z < 5; z++){
    //                 drift = Random.Range(1, 6);
    //                 Instantiate(prefabs[3], placement.position + new Vector3 (x*drift, 10, z*drift), Quaternion.identity);
    //             }
    //         }
    //     }
    //     if(Input.GetKey(KeyCode.K))
    //     {
    //         if(timer>spawnTime){
                
    //             Instantiate(prefabs[PrefabIndex], placement.position, Quaternion.identity);
    //             PrefabIndex ++;
    //             if(PrefabIndex >prefabs.Length-1){
    //                 PrefabIndex=0;
    //             }
    //             spawnTime = timer+interval;
    //         }
    //     }
    //     if(Input.GetKeyUp(KeyCode.K))
    //     {
    //         Instantiate(prefabs[5], placement.position, Quaternion.identity);
    //     }

    }


    }
}
