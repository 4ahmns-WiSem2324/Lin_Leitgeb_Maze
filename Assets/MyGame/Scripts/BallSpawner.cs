using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    public bool spawnBall;
    private Vector3 spawnPos;
    public float spawnTime;

    private void Start()
    {
        spawnPos = gameObject.transform.position;
    }

    private void Update()
    {
        if(spawnBall == true)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        spawnBall = false;
        Instantiate(ball, spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        spawnBall = true;
    }

}
