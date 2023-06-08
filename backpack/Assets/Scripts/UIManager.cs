using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   public GameObject backpack_detail;
   public GameObject backpack_thing1;
   public bool status=false;
   public int thing1=0;
   bool find_thing1=false;

    // Start is called before the first frame update
    void Start()
    {
        backpack_detail.SetActive(status);
        
    }

    // Update is called once per frame
    void Update()
    {
        thing1=ES3.Load("thing1",thing1);
        bool status_thing1=((status==true)&&(thing1==1))||find_thing1;
        if(status_thing1==true){
            //Debug.Log("thing1应该出现");
            //Debug.Log(thing1);
            find_thing1=true;
        }else{
            //Debug.Log("thing1应该隐藏");
            //Debug.Log(thing1);
        }
        backpack_thing1.SetActive(status_thing1);
    }

    public void backpackbuttonOnClick(){
        if(status==false){
            status=true;
        }
        else status=false;
        backpack_detail.SetActive(status);

    }
}
