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
        // ��ȡ����
        // mat.SetTexture("_MainTex", tex); // ��Ȼ�������ҪҲ��������ͼ
        _mat.SetColor("_Color", new Color (1,1,1));

    }

    

    // Update is called once per frame
    void Update()
    {if (dis > 0)
        {
            dis -= 0.01f;
            _mat.SetFloat("_Dissolve", dis); // ���� Shader ��ĳ Color ������ֵ
        }

    }
}
