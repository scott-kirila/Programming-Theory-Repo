using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : ShapeScript
{
    public float _verticalOffset = 1.25f;
    private void Start()
    {
        verticalOffset = _verticalOffset;
    }
    protected override void DisplayText()
    {

    }
}
