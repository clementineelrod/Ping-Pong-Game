using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigid2d;
    private float speed = 350;

    private void Awake()
    {
        _rigid2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        addForce();
    }
    public void ResetPosition()
    {
        _rigid2d.position = Vector3.zero;
        _rigid2d.velocity = Vector3.zero;
   
    }
    public void addForce()
    {
        float x = Random.value;
        if (x < 0.5)
        {
            x = -1.0f;
        }
        else
        {
            x = 1.0f;
        }
        float y = Random.value;
        if (y < 0.5)
        {
            y = Random.Range(-1.0f, -0.5f);
        }
        else
        {
            y = Random.Range(0.5f, 1.0f);
        }
        Vector2 direction = new Vector2(x, y);
        _rigid2d.AddForce(direction * this.speed);
    }
  
}