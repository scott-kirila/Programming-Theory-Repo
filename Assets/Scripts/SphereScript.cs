using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SphereScript : ShapeScript
{
    //ENCAPSULATION
    public string SphereName { get; protected set; }
    public float _verticalOffset = 1.0f;
    private void Start()
    {
        verticalOffset = _verticalOffset;
        SphereName = name;
    }

    // POLYMORPHISM
    protected override string DisplayText()
    {
        string displayName;

        if (string.IsNullOrEmpty(NameField.text))
        {
            displayName = SphereName;

        } else
        {
            displayName = NameField.text;
            NameField.text = "";
        }

        return $"Yo, {displayName} here. Give me a temporary nickname, yeah?";
    }
}
