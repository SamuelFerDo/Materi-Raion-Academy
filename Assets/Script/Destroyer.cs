using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float lifesTime;

    private void Start()
    {
        Destroy(gameObject, lifesTime);
    }
}
