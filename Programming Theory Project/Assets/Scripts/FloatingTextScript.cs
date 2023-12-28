using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingTextScript : MonoBehaviour
{
    public float displayDuration = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, displayDuration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
