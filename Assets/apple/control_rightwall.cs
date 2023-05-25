using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_rightwall : MonoBehaviour
{
    private Ray ra;//射线
    private RaycastHit hit;//碰撞点
    private bool is_element =false;//判断物体
    private int flag = 0;//标志
    private GameObject Element;//控件
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//判断鼠标是否按下
        {
            //发射射线
            ra = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ra, out hit)&&hit.collider.tag=="element")
            {
                is_element = true;
                Element = hit.collider.gameObject;
                if (flag == 0)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            }
        }
 
        if (flag == 1&&is_element)
        {
            /*
            Vector3 targetScreenPos = Camera.main.WorldToScreenPoint(Element.transform.position);
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                targetScreenPos.z);
            Element.transform.position = Camera.main.ScreenToWorldPoint(mousePos);*/
            Element.transform.position += Vector3.right * 1;
        }
    }
   
}
