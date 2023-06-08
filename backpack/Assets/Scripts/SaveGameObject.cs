using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameObject : MonoBehaviour
{
    public int thing1=0;
    // Start is called before the first frame update
    void Start()
    {
        ES3.Save("thing1",thing1);
        Debug.Log(thing1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            Debug.Log("保存");
            ES3.Save("myGameObject",gameObject);
        }
        else if(Input.GetKeyDown(KeyCode.W)){
            Debug.Log("加载");
            GameObject go=ES3.Load("myGameObject",gameObject); //加载的是预制体，不存在场景中
            GameObject instance=Instantiate(go);
            instance.name=gameObject.name;
            Destroy(gameObject);//删除原来的游戏对象
        }
    }

    private void OnMouseDown(){
        Debug.Log("OnMouseDown");
        gameObject.SetActive(false);
        Debug.Log("已放入背包");
        thing1=1;
        ES3.Save("thing1",thing1);
    }
}
