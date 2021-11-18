using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    public float startCD;
    private float CD;
    
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if(CD <= 0)
        {
            int random = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns [random], transform.position, Quaternion.identity);
            CD = startCD;
            if(startCD > minTime)
            {
                startCD -= decreaseTime;
            }
        }
        else
        {
            CD -= Time.deltaTime;
        }
    }
}
