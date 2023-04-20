using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class move_wasd : MonoBehaviour
{
 
    public GameObject cube;
    float speed=5;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cube.transform.Translate(speed * Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            cube.transform.Translate(speed * Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cube.transform.Translate(speed * Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            cube.transform.Translate(speed * Vector3.right * Time.deltaTime);
        }
    }
}
