using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class okbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hint;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void okclick()
    {
        hint.SetActive(false);
    }
}
