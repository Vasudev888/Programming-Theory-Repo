using UnityEngine;
using System;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Color cname;
    public GameObject go;

    private void Start()
    {
        SetColor();
    }

    void SetColor()
    {
        cname = Color.yellow;
    }

    public void Display()
    {
        cname = GetComponent<Renderer>().material.color;
        Debug.Log("deb" + cname);
        GetColorName(cname);
    }


    public void OnMouseEnter()
    {
        Display();
    }


    public string GetColorName(Color color)
    {
        string colornam = "";
        if(color == Color.green)
        {
            colornam = "Green";
        }
        return colornam;
        
    }
}
