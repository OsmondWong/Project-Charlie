using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class EllipseRenderer : MonoBehaviour
{
    LineRenderer lr;

    [Range(24,48)]
    public int segments;
    // public float xAxis = 5f;
    // public float yAxis = 3f;
    public Ellipse ellipse;
    
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
        CalculateEllipse();
    }

    void CalculateEllipse()
    {
        Vector3[] points = new Vector3[segments + 1];
        for (int i = 0; i < segments; i++)
        {
            // float angle = ((float)i / (float)segments) * 360 * Mathf.Deg2Rad;
            // float x = Mathf.Sin(angle) * xAxis;
            // float y = Mathf.Cos(angle) * yAxis;
            Vector2 position2D = ellipse.Evalutate((float)i / (float)segments);
            points [i] = new Vector3(position2D.x, 0f, position2D.y);          //Plains of the ellipse draw on.
        }
        points [segments] = points [0];

        lr.positionCount = segments + 1;
        lr.SetPositions (points);
    }

    void OnValidate()
    {
        if (Application.isPlaying)
            CalculateEllipse();
    }
}
