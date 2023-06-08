using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bkpOnClick : MonoBehaviour
{
    public GameObject bkp;
    int status;
    // Start is called before the first frame update
    void Start()
    {
        bkp.SetActive(false);
        Debug.Log("ye");
        status=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(status%2==0){
            bkp.SetActive(false);

        }
        else
        {
            bkp.SetActive(true);
        }
    }

    public void bkpClick(){
        status++;
        Debug.Log(status);
    }
}
