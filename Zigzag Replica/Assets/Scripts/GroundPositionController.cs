using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GroundSpawnController groundSpawnController;

    private Rigidbody rb;

    [SerializeField] private float endYvalue;

    private int GroundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if(transform.position.y <= endYvalue)
        {
            SetRigidBodyValues();
            SetGroundNewPosition();

        }

        
    }
    private void SetGroundNewPosition()
    {
        GroundDirection = Random.Range(0, 2);

        if (GroundDirection == 0)
        {
            transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x - 1f, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z);
        }
        else
        {
            transform.position = new Vector3(groundSpawnController.lastGroundObject.transform.position.x, groundSpawnController.lastGroundObject.transform.position.y, groundSpawnController.lastGroundObject.transform.position.z + 1f);
        }
        groundSpawnController.lastGroundObject = gameObject;
    }

    private void SetRigidBodyValues()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }
}
