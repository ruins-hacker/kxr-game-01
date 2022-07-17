using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform t;
    Vector3 o;
    // Start is called before the first frame update
    void Start()
    {
        o = transform.position - t.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = t.position + o;
    }
}
