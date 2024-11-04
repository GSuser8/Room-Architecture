using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject wall;       
    public GameObject pillow1;    
    public GameObject pillow2;    

    public Color[] colors = new Color[]
{
    new Color(0.0f, 0.0588f, 0.2902f),   // Blue (#000F4A)
    new Color(1.0f, 0.75f, 0.8f),        // Pink
    new Color(0.5f, 0.0f, 0.5f),         // Purple
    new Color(1.0f, 1.0f, 0.0f),         // Yellow
    new Color(1.0f, 0.5f, 0.0f),         // Orange
    new Color(1.0f, 0.0f, 0.0f),         // Red
    new Color(0.016f, 0.498f, 0.196f),   // Green (#047F32)
    new Color(0.5f, 0.5f, 0.5f),         // Grey
    new Color(0.6f, 0.4f, 0.2f),         // Brown
    new Color(1.0f, 0.0f, 1.0f),         // Magenta
    new Color(0.8f, 0.6f, 0.0f),         // Dark Yellow
    new Color(0.494f, 0.016f, 0.11f),    // Custom Dark Red (#7E041C)
    new Color(0.463f, 0.565f, 0.518f)    // Custom Gray-Green (#769084)
};


    private int currentColorIndex; 
    private void Start()
    {
        currentColorIndex = 0;

        UpdateColors();
    }

    public void ChangeColors()
    {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;

        UpdateColors();
    }

    private void UpdateColors()
    {
        if (colors.Length == 0) return;

        Renderer wallRenderer = wall.GetComponent<Renderer>();
        if (wallRenderer != null)
        {
            wallRenderer.material.color = colors[currentColorIndex];
        }

        Renderer pillow1Renderer = pillow1.GetComponent<Renderer>();
        if (pillow1Renderer != null)
        {
            pillow1Renderer.material.color = colors[currentColorIndex];
        }

        Renderer pillow2Renderer = pillow2.GetComponent<Renderer>();
        if (pillow2Renderer != null)
        {
            pillow2Renderer.material.color = colors[currentColorIndex];
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ChangeColors();
        }
    }
}