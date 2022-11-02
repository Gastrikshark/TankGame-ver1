using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalDespawn : MonoBehaviour
{
    [SerializeField]
    float particalTtl = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        particalTtl -= Time.deltaTime;
        if (particalTtl <= 0)
        {
            Destroy(gameObject);
        }
    }
}
