using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMotion : MonoBehaviour
{
    public Transform orbitingObject;
    public Ellipse orbitPath;

    [Range (0f, 1f)]
    public float orbitProgress = 0f;
    public float orbitPeriod = 3f;
    public bool orbitActive = true;         //so that you can disable orbit when you are not focusing on this planet

    // Start is called before the first frame update
    void Start()
    {
        if (orbitingObject == null)
        {
            orbitActive = false;
            return;
        }
        //set orbiting object position
        //if orbit is active --> start orbit animation
    }

    
}
