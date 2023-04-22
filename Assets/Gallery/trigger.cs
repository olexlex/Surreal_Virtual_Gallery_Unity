using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class trigger : MonoBehaviour
{
    //GameObject button_man;
    public Button man;
    public Button enter;

    public GameObject girl;
    private PlayableDirector director=null;


    void Start()
    {
        
        //按钮消失
        man.transform.gameObject.SetActive(false);
        enter.transform.gameObject.SetActive(false);
        //数字人消失
        /*
        //girl.transform.GetChild(0);
        Material mm1 = girl.transform.GetChild(1).GetComponent<Renderer>().material;
        mm1.SetFloat("_Dissolve",0);
        Material mm2 = girl.transform.GetChild(2).GetComponent<Renderer>().material;
        mm2.SetFloat("_Dissolve",0);
        Material mm3 = girl.transform.GetChild(3).GetComponent<Renderer>().material;
        mm3.SetFloat("_Dissolve",0);
        Material mm4 = girl.transform.GetChild(4).GetComponent<Renderer>().material;
        mm4.SetFloat("_Dissolve",0);
        Material mm5 = girl.transform.GetChild(5).GetComponent<Renderer>().material;
        mm5.SetFloat("_Dissolve",0);
        Material mm6 = girl.transform.GetChild(6).GetComponent<Renderer>().material;
        mm6.SetFloat("_Dissolve",0);
        Material mm7 = girl.transform.GetChild(7).GetComponent<Renderer>().material;
        mm7.SetFloat("_Dissolve",0);
        Material mm8 = girl.transform.GetChild(8).GetComponent<Renderer>().material;
        mm8.SetFloat("_Dissolve",0);
        Material mm9 = girl.transform.GetChild(9).GetComponent<Renderer>().material;
        mm9.SetFloat("_Dissolve",0);
        */
        //灯光消失
        //girl.transform.GetChild(10)
        //获取组件
        director=girl.transform.GetComponent<PlayableDirector>();
        

        //监听按钮点击事件
        man.onClick.AddListener(OnStartButtonClickman);
        enter.onClick.AddListener(OnStartButtonClick_enter);

    

    }
    //按钮点击函数
    public void OnStartButtonClickman()
    {
        //数字人出现
        /*
        Material mm1 = girl.transform.GetChild(1).GetComponent<Renderer>().material;
        Material mm2 = girl.transform.GetChild(2).GetComponent<Renderer>().material;
        Material mm3 = girl.transform.GetChild(3).GetComponent<Renderer>().material;
        Material mm4 = girl.transform.GetChild(4).GetComponent<Renderer>().material;
        Material mm5 = girl.transform.GetChild(5).GetComponent<Renderer>().material;
        Material mm6 = girl.transform.GetChild(6).GetComponent<Renderer>().material;
        Material mm7 = girl.transform.GetChild(7).GetComponent<Renderer>().material;
        Material mm8 = girl.transform.GetChild(8).GetComponent<Renderer>().material;
        Material mm9 = girl.transform.GetChild(9).GetComponent<Renderer>().material;
        mm1.SetFloat("_Dissolve",4);
        mm2.SetFloat("_Dissolve",4);
        mm3.SetFloat("_Dissolve",4);
        mm4.SetFloat("_Dissolve",4);
        mm5.SetFloat("_Dissolve",4);
        mm6.SetFloat("_Dissolve",4);
        mm7.SetFloat("_Dissolve",4);
        mm8.SetFloat("_Dissolve",4);
        mm9.SetFloat("_Dissolve",4);
        */
        //开启动画
        //girl.GetComponent<PlayableDirector>().Play();
        director.Play();
        
    }
    public void OnStartButtonClick_enter()
    {
        Debug.Log("点击enter按钮");//只能运行时看到输出，可以换其他点击事件。
        SceneManager.LoadScene("Water/scene");
    }

    


    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("触发器开始出发:" + other.gameObject.name);

        Debug.Log(girl.transform.GetChild(0));
        Debug.Log(girl.transform.GetChild(1));
        
        //按钮出现

        
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("触发器检测中:" + other.gameObject.name);
        man.transform.gameObject.SetActive(true);
        enter.transform.gameObject.SetActive(true);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("触发器结束:" + other.gameObject.name);
        man.transform.gameObject.SetActive(false);
        enter.transform.gameObject.SetActive(false);
    }

}