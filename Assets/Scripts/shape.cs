using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shape : MonoBehaviour
{
    private Color m_color;// ENCAPSULATION
    public Text shapeText;
    public virtual void ShowMessage() // POLYMORPHISM
    {

    }
    public void SetColor(Color color) // ENCAPSULATION
    {
        m_color = color;
    }
    public Color GetColor() // ENCAPSULATION
    {
        return m_color;
    }
}
