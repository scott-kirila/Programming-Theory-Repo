using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : ShapeScript
{
    public float _verticalOffset = 1.0f;
    private void Start()
    {
        verticalOffset = _verticalOffset;
    }
    protected override void DisplayText()
    {

    }
}
