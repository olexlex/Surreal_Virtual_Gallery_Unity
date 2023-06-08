using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeOnTouch : MonoBehaviour
{
    public int flag;
    public GameObject hint;
    public GameObject h1=null;//cube
    public GameObject h2=null;//cube

    public GameObject h3=null;//pipe outline
    public GameObject h4=null;//pipe

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log($"保存路径：{Application.persistentDataPath}");
        hint.SetActive(false);
        //ES3.Save("hint1",0);
        h4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        gameObject.SetActive(false);
        wall.transform.position += Vector3.right * 100;
        wall.transform.GetChild(1).position += Vector3.right * 100;
        hint.SetActive(true);
        if(flag==1){
            ES3.Save("hint1",1);
            h1.SetActive(false);
            h2.SetActive(false);
            h4.SetActive(true);
            Destroy(h3);
        }
    }
}
