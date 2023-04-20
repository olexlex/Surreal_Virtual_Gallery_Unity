using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoTextChange : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = transform.GetComponent<TextMeshProUGUI>();
        Text.alpha = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

