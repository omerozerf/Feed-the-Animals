using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float areaLine;

    [SerializeField] private GameObject food;
    
    
    


    private void Update()
    {
        Move();
        StayInGameArea();
        ThrowFood();
    }

    private void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal"); 
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * horizontalSpeed);
    }

    private void StayInGameArea()
    {
        if (transform.position.x > areaLine)
        {
            transform.position = new Vector3(areaLine, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -areaLine)
        {
            transform.position = new Vector3(-areaLine, transform.position.y, transform.position.z);
        }
    }

    private void ThrowFood()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food, transform.position, food.transform.rotation);
        }
    }
}
