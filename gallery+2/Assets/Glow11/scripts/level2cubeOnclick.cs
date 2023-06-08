using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2cubeOnclick : MonoBehaviour
{
    public int flag;
    public GameObject hint;
    public GameObject bkp=null;
    public GameObject h3=null;
    public GameObject h4=null;

    // Start is called before the first frame update
    void Start()
    {
        hint.SetActive(false);
        bkp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        Debug.Log("touch");
        gameObject.SetActive(false);
        hint.SetActive(true);
        if(flag==2){
            h4.SetActive(true);
            Destroy(h3);
        }
    }

}
