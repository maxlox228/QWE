using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graviti : MonoBehaviour
{
    public float WorldTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        WorldTime += Time.deltaTime;

        if (WorldTime > 10)
        {
            Physics.gravity = new Vector3(0, -20.0F, 0);
        }

        if (WorldTime > 15)
        {
            Physics.gravity = new Vector3(0, -40.0F, 0);
        }

        if (WorldTime > 20)
        {
            Physics.gravity = new Vector3(0, -60.0F, 0);
        }

        if (WorldTime > 30)
        {
            Physics.gravity = new Vector3(0, -100.0F, 0);
        }

    }
}
