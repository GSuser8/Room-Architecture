using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerK : MonoBehaviour
{
    public GameObject wall;
    public GameObject pillow1;
    public GameObject pillow2;
    public GameObject rug; // Added for the rug

    public Color[] colors = new Color[]
    {
        new Color(0.933f, 0.341f, 0.565f),   // Pink
        new Color(0.5f, 0.0f, 0.5f),         // Purple
        new Color(1.0f, 0.5f, 0.0f),         // Orange
        new Color(1.0f, 0.0f, 0.0f),         // Red
        new Color(0.631f, 0.871f, 0.616f),   // Green 
        new Color(0.196f, 0.173f, 0.180f),   // Grey
        new Color(0.6f, 0.4f, 0.2f),         // Brown
        new Color(0.263f, 1.0f, 0.941f),     // Blue
        new Color(0.8f, 0.6f, 0.0f),         // Dark Yellow
        new Color(0.475f, 0.388f, 0.890f),   // Royal purple
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

        Renderer rugRenderer = rug.GetComponent<Renderer>(); // Added for the rug
        if (rugRenderer != null)
        {
            rugRenderer.material.color = colors[currentColorIndex];
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
