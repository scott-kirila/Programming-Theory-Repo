using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CubeScript : ShapeScript
{
    //ENCAPSULATION
    public string CubeName {  get; protected set; }
    public float _verticalOffset = 0.75f;

    private void Start()
    {
        verticalOffset = _verticalOffset;
        CubeName = name;
    }

    // POLYMORPHISM
    protected override string DisplayText()
    {
        if (!string.IsNullOrEmpty(NameField.text))
        {
            CubeName = NameField.text;
            NameField.text = "";
        }

        return $"Hi, I'm {CubeName}, and you can permanently change my name!";
    }
}
