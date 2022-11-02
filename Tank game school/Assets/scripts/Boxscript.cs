using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;



public class Boxscript : MonoBehaviour
{
    public float strength = 0.01f;
    public float speed = 1; 
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin(Time.time * speed);
        transform.Translate(Vector2.up * strength * y);
        transform.Translate(Vector2.right * strength * y);
    }
}
