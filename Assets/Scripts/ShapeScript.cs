using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public abstract class ShapeScript : MonoBehaviour
{
    public TMP_InputField NameField;
    public GameObject floatingTextPrefab;
    protected float verticalOffset;
    Camera m_Camera;

    private void Awake()
    {
        m_Camera = Camera.main;
        NameField = GameObject.Find("NameField").GetComponent<TMP_InputField>();
    }

    private void Update()
    {
        if (floatingTextPrefab != null)
        {
            DetectClick();
        }
    }

    protected abstract string DisplayText();

    protected bool DetectClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.name == name && transform.childCount == 0)
                {
                    Vector3 direction = transform.position - m_Camera.transform.position;
                    Quaternion rotation = Quaternion.LookRotation(direction);
                    
                    var floatingText = Instantiate(floatingTextPrefab, transform.position, rotation, transform);

                    floatingText.GetComponent<TMP_Text>().text = DisplayText(); // name;
                    floatingText.transform.localPosition = Vector3.up * verticalOffset;
                    
                    return true;
                }
            }
        }

        return false;
    }
}