using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeView : MonoBehaviour
{
    private CubeController _controller;
    
    private float _speed;
    
    private MeshRenderer _meshRenderer;
    private Material _material;
    
    // Start is called before the first frame update
    void Start()
    {
        _controller = new CubeController();
        
        _speed = .5f;
        
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = new Material(Shader.Find("Standard"));
        
        transform.localPosition = _controller.Position;
        transform.localEulerAngles = _controller.Rotation;
        transform.localScale = _controller.Scale;
    }

    // Update is called once per frame
    void Update()
    {
        //Move
        float moveAmount = 0;
        CubeController.Axis moveAxis = CubeController.Axis.X;
        
        if (Input.GetKey(KeyCode.W))
        {
            moveAmount = 1;
            moveAxis = CubeController.Axis.Z;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            moveAmount = -1;
            moveAxis = CubeController.Axis.Z;
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            moveAmount = 1;
            moveAxis = CubeController.Axis.X;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            moveAmount = -1;
            moveAxis = CubeController.Axis.X;
        }

        _controller.Move(moveAmount * _speed, moveAxis);
        transform.localPosition = _controller.Position;
        
        //Scale
        float scaleAmount = 0;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            scaleAmount = 1;
        }
    
        if (Input.GetKey(KeyCode.DownArrow))
        {
            scaleAmount = -1;
        }

        _controller.Scaling(scaleAmount);
        transform.localScale = _controller.Scale;
        
        //Rotate
        float rotateAmount = 0;
        CubeController.Axis rotateAxis = CubeController.Axis.X;
        
        if (Input.GetKey(KeyCode.J))
        {
            rotateAmount = 1;
            rotateAxis = CubeController.Axis.Z;
        }
    
        if (Input.GetKey(KeyCode.L))
        {
            rotateAmount = -1;
            rotateAxis = CubeController.Axis.Z;
        }
        
        if (Input.GetKey(KeyCode.I))
        {
            rotateAmount = 1;
            rotateAxis = CubeController.Axis.X;
        }
    
        if (Input.GetKey(KeyCode.K))
        {
            rotateAmount = -1;
            rotateAxis = CubeController.Axis.X;
        }

        _controller.Rotate(rotateAmount, rotateAxis);
        transform.localEulerAngles = _controller.Rotation;
        
        //Colouring
        if (Input.GetKey(KeyCode.R))
        {
            _controller.ToRed();
        }
        
        if (Input.GetKey(KeyCode.G))
        {
            _controller.ToGreen();
        }
        
        if (Input.GetKey(KeyCode.B))
        {
            _controller.ToBlue();
        }
        
        _material.color = _controller.Colour;
        _meshRenderer.material = _material;
    }
}
