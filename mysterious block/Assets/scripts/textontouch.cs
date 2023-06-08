using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textontouch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pic;

    void Start()
    {
        pic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        pic.SetActive(true);
    }
}
