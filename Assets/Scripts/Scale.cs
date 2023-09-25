using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _timer = 10.0f;

    [SerializeField] private Vector3 _scale;

    [SerializeField] private Vector3 _newscale; 

    void Start()
    {
        _scale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z); 

        _newscale = _scale;
    }

    void Update()
    {
        _timer -= 1.0f * Time.deltaTime;

        transform.localScale = Vector3.Lerp(transform.localScale, _newscale, Time.deltaTime);

        if (_timer <= 0.0f)
        {
            _newscale = new Vector3(Random.Range(2.0f, 10.0f), Random.Range(2.0f, 10.0f), Random.Range(2.0f, 10.0f));

            _timer = 10.0f; 
        }
    }
}
