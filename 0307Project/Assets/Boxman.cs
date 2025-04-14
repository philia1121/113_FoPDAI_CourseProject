using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxman : MonoBehaviour
{
    public float addValue;
    public float rotateSpeed;
    public float moveSpeed;
    public Vector3 rotateDirection;
    public Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        // addValue = 0;
        // addValue = 100/5;
        // Debug.Log(addValue);
    }

    // Update is called once per frame
    void Update()
    {
        // 新的addValue 會= 現在的addValue(0) + 0.05f;
        // 你的年齡 = 你(過生日的前一秒)的年齡 + 1; // 所謂過生日長一歲的瞬間
        // addValue = addValue + 0.05f;
        transform.Rotate(rotateDirection*(rotateSpeed + addValue));
        transform.Translate(moveDirection*moveSpeed);
    }
}
