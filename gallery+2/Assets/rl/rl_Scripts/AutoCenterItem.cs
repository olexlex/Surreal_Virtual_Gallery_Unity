using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class AutoCenterItem : MonoBehaviour
{
    //��ť���
    public Button _ItemBtn;
    //Image���
    public Image _itemImage;
    //����
    public int _itemIndex;
   
    //��ʼ������ȡ���
    public void InitAutoCenterItem()
    {
        _itemImage = GetComponent<Image>();
        _ItemBtn = GetComponent<Button>();
        
    }
}
