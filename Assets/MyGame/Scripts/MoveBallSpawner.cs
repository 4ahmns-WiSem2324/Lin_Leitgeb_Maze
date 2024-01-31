using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallSpawner : MonoBehaviour
{
    public float amplitude = 1.0f;
    public float speed = 2.0f;
    public float minY = 1.0f;
    public float maxY = 5.0f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * speed) * amplitude;

        float newY = initialPosition.y + verticalMovement;

        newY = Mathf.Clamp(newY, minY, maxY);

        transform.position = new Vector3(initialPosition.x, newY, initialPosition.z);
    }
}
