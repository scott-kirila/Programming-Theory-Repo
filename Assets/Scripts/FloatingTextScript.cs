using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FloatingTextScript : MonoBehaviour
{
    float displayDuration = 2.0f;
    float fadeTimeElasped;
    float fadeDuration = 0.35f;
    TMP_Text m_Text;

    private void Awake()
    {
        m_Text = GetComponent<TMP_Text>();
    }

    void Start()
    {
        Destroy(gameObject, displayDuration);
    }

    void Update()
    {
        displayDuration -= Time.deltaTime;

        if (displayDuration < fadeDuration)
        {
            float value = Mathf.Lerp(1.0f, 0.0f, fadeTimeElasped / fadeDuration);
            m_Text.color = new Color(m_Text.color.r, m_Text.color.g, m_Text.color.b, value);
            fadeTimeElasped += Time.deltaTime;
        }
    }
}
