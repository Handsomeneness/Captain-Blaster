using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float _speed = -2f;
    public float _lowerYValue = -20f;
    public float _upperYValue = 40;
    void Update()
    {
        transform.Translate(0f, _speed * Time.deltaTime, 0f);
        if (transform.position.y <= _lowerYValue)
        {
            transform.Translate(0f, _upperYValue, 0f);
        }
    }
}
