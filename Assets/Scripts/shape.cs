using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape
{
    private Color m_color;// ENCAPSULATION
    public virtual void ShowMessage()
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
