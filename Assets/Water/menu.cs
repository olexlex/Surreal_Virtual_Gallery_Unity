using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Button bt;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<move_wasd>().enabled = true;
        this.GetComponent<Mouselook>().enabled = true;

        bt.onClick.AddListener(Click_DisplayMenu);
    }

    public void Click_DisplayMenu()
    {
        Debug.Log("点击按钮");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("按下鼠标右键");
            this.GetComponent<move_wasd>().enabled = false;
            this.GetComponent<Mouselook>().enabled = false;
        }
        */

            

    }
}
