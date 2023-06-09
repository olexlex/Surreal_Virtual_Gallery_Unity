 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class SimpleCameraController : MonoBehaviour
 {
 
     float speed = 8;
     public float rotation_H_speed =1 ;
     public float rotation_V_speed =1 ;
     public float max_up_angle =1 ;              //越大，头抬得越高
     public float max_down_angle =1 ;           //越小，头抬得越低
     public float rotationSpeed = 50.0f;
 
     private float current_rotation_H;  //水平旋转结果
     private float current_rotation_V;  //垂直旋转结果

     // Use this for initialization
     void Start()
     {
 
     }
 
     // Update is called once per frame
    void Update()
    {
         // 移动
        if (Input.GetKey(KeyCode.A)) //左移
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) //右移
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
 
        }
        if (Input.GetKey(KeyCode.W)) //前移
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
 
        }
        if (Input.GetKey(KeyCode.S)) //后移
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
 
        }
         // 旋转
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
 }

