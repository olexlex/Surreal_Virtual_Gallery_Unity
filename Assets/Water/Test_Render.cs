using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_Render : MonoBehaviour
{
    public Texture2D tex;
    public Image img;
    public Cubemap cumap;
    public Cubemap cumap1;
    public Texture matTex;
    public Material ma;
    public Texture2D texFix;
    private Byte[] bytes;
    int width;
    private void Start()
    {
        width = 1024;
        //img = gameObject.GetComponent<Image>();   
        cumap = new Cubemap(width,TextureFormat.ARGB32,false);
        cumap1 = new Cubemap(width,TextureFormat.ARGB32, false);
        //拿到材质组件
        ma = gameObject.GetComponent<MeshRenderer>().material;
        //拿到material里面叫_MainTex的贴图
        matTex = ma.GetTexture("painting");
        tex = new Texture2D(width,width);
        texFix = new Texture2D(width,width);
        //bytes = new byte[Screen.height*Screen.width];
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            Camera.main.RenderToCubemap(cumap);            
            //tex.SetPixels(cumap.GetPixels(CubemapFace.PositiveZ)) ;
            //拿到z方向上的贴图（是反的后面要反过来）
            Color[] cmmcolors = cumap.GetPixels(CubemapFace.PositiveZ);
            //给要复制的东西提供位置
            Color[] ReCmmcolors = new Color[cmmcolors.Length]; 
            //遍历贴图x方向把x方向上每个点的y值反过来(实现将图上下翻转)
            for (int i = 1; i < width + 1; i++)
                Array.Copy(cmmcolors, width * (width - i), ReCmmcolors, width * (i - 1), width);//上下翻转
            //将这个立方贴图的值给这个2d图
            tex.SetPixels(ReCmmcolors);
            tex.Apply();
            //img.sprite = Sprite.Create(tex, new Rect(0, 0, Screen.width, Screen.height), Vector2.zero);
            ma.SetTexture("_MainTex", tex);
            bytes = tex.EncodeToPNG();
            texFix.LoadImage(bytes);
            texFix.Apply();
            cumap1.SetPixels(texFix.GetPixels(), CubemapFace.PositiveZ);
            cumap1.Apply();
        }
    }
}

