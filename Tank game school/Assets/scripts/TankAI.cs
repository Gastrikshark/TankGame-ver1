using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAI : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    public Transform target;
    public float minimumDistance;
    public GameObject Bullet;
    public float timeBetweemShots;
    bool IsAanDeBeurt = false;
    [SerializeField]
    Material actiefMat;
    [SerializeField]
    Material inactiefMat;
    // Update is called once per frame
    private void Update()
    {


        if(Vector2.Distance(transform.position, target.position) < minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position,-speed*Time.deltaTime);
        }
       
    }

    public void ZetActief(bool b)
    {
        if (b == true)
        {
            IsAanDeBeurt = true;
            GetComponent<SpriteRenderer>().material = actiefMat;
        }
        else
        {
            IsAanDeBeurt = false;
            GetComponent<SpriteRenderer>().material = inactiefMat;

        }

    }
}