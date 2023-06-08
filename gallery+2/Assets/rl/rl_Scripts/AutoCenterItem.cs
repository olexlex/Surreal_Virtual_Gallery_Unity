using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class AutoCenterItem : MonoBehaviour
{
    //按钮组件
    public Button _ItemBtn;
    //Image组件
    public Image _itemImage;
    //索引
    public int _itemIndex;
   
    //初始化并获取组件
    public void InitAutoCenterItem()
    {
        _itemImage = GetComponent<Image>();
        _ItemBtn = GetComponent<Button>();
        
    }
}
