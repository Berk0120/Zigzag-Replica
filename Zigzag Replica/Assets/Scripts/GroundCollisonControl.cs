using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisonControl : MonoBehaviour
{

    [SerializeField] private GroundDataTransMitter groundDataTransMitter;

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransMitter.SetGroundRigidBodyValues();
        }
    }

}
