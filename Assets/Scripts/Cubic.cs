using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubic : shape
{
   // INHERITAMCE POLYMORPHISM
    public override void ShowMessage()
    {
        shapeText.text = "This is Cube";
        
    }

    void OnMouseDown()
    {
        ShowMessage(); // ABSTRACTION
        GetComponent<Renderer>().material.color = GetColor();
    }
    void Start()
    {
        SetColor(Color.blue);
    }
}
