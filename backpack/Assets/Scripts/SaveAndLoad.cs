using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndLoad : MonoBehaviour
{
    public string myStr;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"保存路径：{Application.persistentDataPath}");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            ES3.Save("myStr",myStr);
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            myStr=ES3.Load("myStr","SaveFile.es3","");
        }
    }
}
