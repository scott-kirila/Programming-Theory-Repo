using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : ShapeScript
{
    public string CubeName {  get; protected set; }
    public float _verticalOffset = 0.75f;

    private void Start()
    {
        verticalOffset = _verticalOffset;
        CubeName = name;
    }
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
