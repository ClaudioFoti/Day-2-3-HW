using UnityEngine;

public class CubeController
{
    private readonly CubeModel _cubeModel;

    public enum Axis {X, Y, Z}
        
    public CubeController()
    {
        _cubeModel = new CubeModel();
    }
        
    public CubeController(Vector3 position, Vector3 rotation, Vector3 scale, Color colour)
    {
        _cubeModel = new CubeModel(position, rotation, scale, colour);
    }
        
    public Vector3 Position => _cubeModel.Position;

    public Vector3 Rotation => _cubeModel.Rotation;

    public Vector3 Scale => _cubeModel.Scale;

    public Color Colour => _cubeModel.Colour;

    private void _rotate(Vector3 rotation)
    {
        Vector3 finalRotation = new Vector3(
            _cubeModel.Rotation.x + rotation.x,
            _cubeModel.Rotation.y + rotation.y,
            _cubeModel.Rotation.z + rotation.z
        );

        _cubeModel.Rotation = finalRotation;
    }

    public void Rotate(float amount, Axis axis)
    {
        Vector3 rotation = new Vector3(0, 0, 0);
            
        switch (axis)
        {
            case Axis.X:
                rotation.x = amount;
                break;
            case Axis.Y:
                rotation.y = amount;
                break;
            case Axis.Z:
                rotation.z = amount;
                break;
        }
            
        _rotate(rotation);
    }

    private void _scale(Vector3 scaling)
    {
        float xScale = _cubeModel.Scale.x + scaling.x; 
        float yScale = _cubeModel.Scale.y + scaling.y; 
        float zScale = _cubeModel.Scale.z + scaling.z;

        if(xScale > 0 && yScale > 0 && zScale > 0)
        {
            _cubeModel.Scale = new Vector3(xScale, yScale, zScale);
        }
    }
    
    public void Scaling(float amount)
    {
        _scale(new Vector3(amount, amount, amount));
    }
        
    private void _move(Vector3 position)
    {
        Vector3 finalScaling = new Vector3(
            _cubeModel.Position.x + position.x,
            _cubeModel.Position.y + position.y,
            _cubeModel.Position.z + position.z
        );

        _cubeModel.Position = finalScaling;
    }
        
    public void Move(float amount, Axis axis)
    {
        Vector3 position = new Vector3(0, 0, 0);
            
        switch (axis)
        {
            case Axis.X:
                position.x = amount;
                break;
            case Axis.Y:
                position.y = amount;
                break;
            case Axis.Z:
                position.z = amount;
                break;
        }
            
        _move(position);
    }

    public void ToRed()
    {
        _cubeModel.Colour = new Color(255, 0, 0);
    }
    
    public void ToGreen()
    {
        _cubeModel.Colour = new Color(0, 255, 0);
    }
    
    public void ToBlue()
    {
        _cubeModel.Colour = new Color(0, 0, 255);
    }
}