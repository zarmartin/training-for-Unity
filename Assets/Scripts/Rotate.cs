using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed = 7.0f;
    void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);        
    }
}
