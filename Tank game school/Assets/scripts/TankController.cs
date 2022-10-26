using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField] 
    Transform BarrelBeavior;
    [SerializeField]
    Transform firepoint;
    [SerializeField]
    GameObject bulletToFire;
    [SerializeField]
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        BarrelBeavior.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            GameObject b= Instantiate(bulletToFire, firepoint.position, firepoint.rotation);
            b.GetComponent<Rigidbody2D>().AddForce(BarrelBeavior.up * speed,ForceMode2D.Impulse);
        }
    }

}
