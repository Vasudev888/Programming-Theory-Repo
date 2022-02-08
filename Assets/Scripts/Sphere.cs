using UnityEngine;
using UnityEngine.UI;

public class Sphere : Shapes
{
    public RectTransform textPanel;
    public Text textInfo;

    public string strName { get; set; }
    public Color _color { get; set; }

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

        strName = shapeName;
        _color = shapeColor;

        textInfo.text = "This is : " + strName + "\n Color is : " + GetShapeColor(_color);
    }
}
