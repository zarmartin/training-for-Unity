using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinPong : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    [SerializeField] private Vector3 _pos1;

    [SerializeField] private Vector3 _pos2;

    [System.Obsolete]
    void Start()
    {
        _pos1 = new Vector3(Random.RandomRange(2.0f, 12.0f), Random.RandomRange(2.0f, 12.0f), Random.RandomRange(2.0f, 12.0f));

        _pos2 = new Vector3(Random.RandomRange(-12.0f, -2.0f), Random.RandomRange(-12.0f, -2.0f), Random.RandomRange(-12.0f, -2.0f));
    }

    void Update()
    {
        transform.position = Vector3.Lerp(_pos1, _pos2, Mathf.PingPong(Time.time * _speed, 1.0f));
    }
}
