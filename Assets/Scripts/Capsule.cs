using UnityEngine;
using UnityEngine.UI;

public class Capsule : Shapes
{
    public RectTransform textPanel;
    public Text textInfo;

    public Color _color;
    public string strName;

    public void OnMouseEnter()
    {
        DisplayText();
        StartCoroutine(DelayPanel(textPanel.gameObject));
    }

    public void OnMouseExit()
    {
        textPanel.gameObject.SetActive(false);
    }

    public void OnMouseOver()
    {
        textPanel.transform.position = new Vector2(Input.mousePosition.x + textPanel.sizeDelta.x / 2, Input.mousePosition.y + textPanel.sizeDelta.y / 2);
    }

    public override void DisplayText()
    {
        base.DisplayText();
        strName = name;
        _color = color;

        textInfo.text = "This is  : " + name + "\nColour is : " + GetShapeColor(_color);
    }
}
