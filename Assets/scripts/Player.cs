using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        dir.Normalize();
        transform.position += dir * speed;

        /*if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0);
        }*/
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Portal")
        {
            transform.position = new Vector3(-10, 1, 0);
        }
        if (other.gameObject.name == "round")
        {
            transform.position = new Vector3(-10, 1, 0);
        }
        if (other.gameObject.name == "Portal1")
        {
            transform.position = new Vector3(-52, 1, 0);
        }
        if (other.gameObject.name == "round1")
        {
            transform.position = new Vector3(-52, 1, 0);
        }
        if (other.gameObject.name == "Portal2")
        {
            transform.position = new Vector3(-122, 1, 83);
        }
        if (other.gameObject.name == "1")
        {
            transform.position = new Vector3(-122, 1, 83);
        }
    }
}
