using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float upBound = 30;
    private float bottomBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upBound)
            Destroy(gameObject);
        else if (transform.position.z < bottomBound)
            Destroy(gameObject);
    }
}
