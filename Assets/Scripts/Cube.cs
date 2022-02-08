using UnityEngine;
using UnityEngine.UI;


public class Cube : Shapes
{
    public RectTransform textPanel;
    public Text textinfo;

    public string strName { get; set; }
    public Color _color { get; set; }

    private void OnMouseEnter()
    {
        DisplayText();
        StartCoroutine(DelayPanel(textPanel.gameObject));
    }

    private void OnMouseExit()
    {
        textPanel.gameObject.SetActive(false);
    }

    private void OnMouseOver()
    {
        textPanel.transform.position = new Vector2(Input.mousePosition.x + textPanel.sizeDelta.x / 2, Input.mousePosition.y + textPanel.sizeDelta.y / 2);
    }

    public override void DisplayText()
    {
        base.DisplayText();

        strName = shapeName;
        _color = shapeColor;
        textinfo.text = "This is : " + strName + " \nColor is  : " + GetShapeColor(_color);
    }
}
