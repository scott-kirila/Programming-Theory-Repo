using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : ShapeScript
{
    public float _verticalOffset = 0.75f;

    private void Start()
    {
        verticalOffset = _verticalOffset;
    }
    protected override void DisplayText()
    {

    }
}
