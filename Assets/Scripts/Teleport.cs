using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Vector3 description;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            description = transform.position;

            transform.position = new Vector3(Random.RandomRange(-10.0f, 10.0f),
                Random.RandomRange(-10.0f, 10.0f),
                Random.RandomRange(-10.0f, 10.0f));
        }
    }
}
