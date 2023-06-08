using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeonTouch : MonoBehaviour
{
    // Start is called before the first frame update
    public int flag;

    public GameObject h1=null;
    public GameObject h2=null;
    public GameObject hint;
    public GameObject people=null;
    public GameObject text=null;
    void Start()
    {
        hint.SetActive(false);
        people.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        hint.SetActive(true);
        if (flag == 1)
        {
            h1.SetActive(false);
            h2.SetActive(false);
            people.SetActive(true);
        }
    }
}
