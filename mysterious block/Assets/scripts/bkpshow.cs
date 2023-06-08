using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bkpshow : MonoBehaviour
{
    // Start is called before the first frame update
    int status = 0;
    public GameObject hint;
    void Start()
    {
        hint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        status++;
        if (status % 0 == 1)
        {
            hint.SetActive(true);
        }
        else
        {
            hint.SetActive(false);
        }
    }
}
