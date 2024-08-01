using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private Transform _cam;
    [SerializeField] private float _moveSpeed;

    void Update()
    {
        transform.Translate(-1 * _moveSpeed * Time.deltaTime, 0f, 0f);
        if (_cam.position.x >= transform.position.x + 150f)
        {
            transform.position = new Vector2(
                   _cam.position.x + 150f,
                   transform.position.y
                );
        }
    }
}