using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_test : MonoBehaviour
{
    public void OnStartButtonClick_man()
    {
        Debug.Log("点击man按钮");//只能运行时看到输出，可以换其他点击事件。
    }
    public void OnStartButtonClick_enter()
    {
        Debug.Log("点击enter按钮");//只能运行时看到输出，可以换其他点击事件。
    }
}
