using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitRestore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitOnClick(){
        int thing1=0;
        ES3.Save("thing1",thing1);
    }
}
