using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shapes : MonoBehaviour
{
    public float volume;
    public float weight;
    public Vector3 position;
    /*public string colorName;*/
    public string shapeName { get; set; }
    public Color shapeColor { get; set; }

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
        shapeColor = GetComponent<Renderer>().material.color;
    }

/*    public string GetColor(string _color)
    {
        this.colorName = _color;
        return colorName;
    }
*/

    public IEnumerator DelayPanel(GameObject panel)
    {

        yield return new WaitForSeconds(timeToWait);
        panel.SetActive(true);
    }

    /// <summary>
    /// Check whether the color we are passing in is equals to one of the colors we are checking against.
    /// If it is, return the name of the color in string format
    /// </summary>
    /// <param name="color">The color that we want to compare</param>
    /// <returns>The name of the color</returns>

    public string GetShapeColor(Color color)
    {
        string colorName = string.Empty;
        
        if(color == Color.red)
        {
            colorName = "Red";
        }
        else if(color == Color.green)
        {
            colorName = "Green";
        }
        else if (color == Color.blue)
        {
            colorName = "Blue";
        }

        else if (color == Color.yellow)
        {
            colorName = "Yellow";
        }

        return colorName;
       
    }



}
