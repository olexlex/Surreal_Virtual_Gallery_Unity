using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disove : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public float dis=5.0f;
    private Material _mat;
    void Start()
    {
        _mat = gameObject.GetComponent<MeshRenderer>().materials[0];
        // 获取材质
        // mat.SetTexture("_MainTex", tex); // 当然如果有需要也可设置贴图
        _mat.SetColor("_Color", new Color (1,1,1));

    }

    

    // Update is called once per frame
    void Update()
    {if (dis > 0)
        {
            dis -= 0.01f;
            _mat.SetFloat("_Dissolve", dis); // 设置 Shader 中某 Color 变量的值
        }

    }
}
