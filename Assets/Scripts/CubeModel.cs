using UnityEngine;

public class CubeModel
{
    public CubeModel()
    {
        Position = new Vector3(0, 0, 0);
        Rotation = new Vector3(0, 0, 0);
        Scale = new Vector3(1, 1, 1);
        Colour = new Color(255, 255, 255);
    }
        
    public CubeModel(Vector3 position, Vector3 rotation, Vector3 scale, Color colour)
    {
        Position = position;
        Rotation = rotation;
        Scale = scale;
        Colour = colour;
    }

    public Vector3 Position { get; set; }

    public Vector3 Rotation { get; set; }

    public Vector3 Scale { get; set; }
    
    public Color Colour { get; set; }
}