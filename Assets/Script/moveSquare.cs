using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSquare : MonoBehaviour
{
    [SerializeField] private float _spd;
    [SerializeField] private float MaxDistance;
    private Vector3 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, v, 0);
        transform.position += dir * _spd * Time.deltaTime; 

        if (Vector2.Distance(StartPosition, transform.position) > MaxDistance)
        {
            transform.position = StartPosition;
        }
    }
}
