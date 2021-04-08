using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movableBackground_2 : MonoBehaviour
{
    public float HorizontalSpeed = 30;
    public float MaxHorizontalPosition = -1100;
    public float MinHorizontalPosition = 1100;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        Vector2 position = rectTransform.anchoredPosition;

        position.x += HorizontalSpeed * Time.deltaTime;

        if (position.x > MaxHorizontalPosition)
            position.x = MinHorizontalPosition;

        rectTransform.anchoredPosition = position;
    }
}

