using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public abstract class ShapeScript : MonoBehaviour
{
    public GameObject floatingTextPrefab;
    protected float verticalOffset;
    Camera m_Camera;

    private void Awake()
    {
        m_Camera = Camera.main;
    }

    private void Update()
    {
        if (floatingTextPrefab != null)
        {
            DetectClick();
        }
    }

    protected abstract void DisplayText();

    protected bool DetectClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.name == name)
                {
                    Vector3 direction = transform.position - m_Camera.transform.position;
                    Quaternion rotation = Quaternion.LookRotation(direction);
                    
                    var floatingText = Instantiate(floatingTextPrefab, transform.position, rotation, transform);
                    
                    floatingText.GetComponent<TMP_Text>().text = name;
                    floatingText.transform.localPosition = Vector3.up * verticalOffset;
                    
                    Debug.Log($"You clicked {name}!");

                    return true;
                }
            }
        }

        return false;
    }
}