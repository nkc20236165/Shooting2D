using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  // 移動方法を保存する変数
    // Start is called before the first frame update
    void Start()
    {
        float speed = 5;
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //画面内移動制限
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-9f,9f);
        pos.y = Mathf.Clamp(pos.x, -5f, 5f);
        transform.position = pos;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
