using UnityEngine;

public class Shapes 
{
    private string colorName { get; set; }
    public string shapeName;
    public float volume;
    public float weight;
    public Color color;

    public string GetColor(string _color)
    {
        this.colorName = _color;
        return colorName;
    }

    
}


public class Cube : Shapes
{

}

public class Sphere : Shapes
{

}

public class Capsule : Sphere
{

}
