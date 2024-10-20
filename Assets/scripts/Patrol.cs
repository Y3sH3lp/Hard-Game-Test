using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public GameObject target;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
    }
}
