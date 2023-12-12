using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Shape
{
    Sphere,
    Box,

}

public class CheckLayer : MonoBehaviour
{
    [SerializeField] private Shape shape;
    [SerializeField] private float Distance;

    private void Awake()
    {
        if(shape == 0)
        {

        }
    }

    private void SphereCast()
    {
        Ray r;
        Physics.SphereCast(, Distance);
    }
}
