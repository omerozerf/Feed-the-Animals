using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float destroyRange;
    
    private void Update()
    {
        Move();
        DestroyAnimals();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            UIController.WinScore();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
    
    private void DestroyAnimals()
    {
        if (transform.position.z < destroyRange)
        {
            UIController.LoseLife();
            Destroy(gameObject);
        }
    }
}
