using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITAMCE
public class Ball : shape
{
    
    // INHERITAMCE POLYMORPHISM
    public override void ShowMessage()
    {
        shapeText.text = "This is Ball";
        
    }

    void OnMouseDown()
    {
        ShowMessage(); // ABSTRACTION
        GetComponent<Renderer>().material.color = GetColor();
    }
    void Start()
    {
        SetColor(Color.red);
    }

}
