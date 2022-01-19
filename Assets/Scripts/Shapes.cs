using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class Shapes : MonoBehaviour
{
    public string colorName { get; set; }
    public string shapeName { get; set; }
    public float volume;
    public float weight;
    public Vector3 position;
    public Color color;

    [SerializeField]
    private float timeToWait = 0.2f;

/*    public Shapes(string sname, float vol, float wt, Vector3 pos)
    {
        shapeName = sname;
        volume = vol;
        weight = wt;
        position = pos;

    }*/

    public virtual void DisplayText()
    {
        shapeName = name;
        color = GetComponent<Renderer>().material.color;
    }

    public string GetColor(string _color)
    {
        this.colorName = _color;
        return colorName;
    }


    public IEnumerator DelayPanel(GameObject panel)
    {

        yield return new WaitForSeconds(timeToWait);
        panel.SetActive(true);
    }


    public string GetShapeColor(Color color)
    {
        colorName = string.Empty;

        if(color == Color.red)
        {
            colorName = "Red";
        }
        else if(color == Color.green)
        {
            colorName = "Green";
        }
        else if(color == Color.yellow)
        {
            colorName = "Yellow";
        }

        return colorName;
    }

}
