using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class CylinderScript : ShapeScript
{
    //ENCAPSULATION
    public string CylinderName { get; protected set; }
    public float _verticalOffset = 1.25f;
    private void Start()
    {
        verticalOffset = _verticalOffset;
        CylinderName = name;
    }

    // POLYMORPHISM
    protected override string DisplayText()
    {
        NameField.text = "";
        return $"I'm {CylinderName}. Don't you dare try to change my name.";
    }
}
