using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransMitter : MonoBehaviour
{
    [SerializeField] private GroundFallControl groundFallControl;

    public void SetGroundRigidBodyValues()
    {
        StartCoroutine(groundFallControl.SetRigidBodyValues());
    }
}
