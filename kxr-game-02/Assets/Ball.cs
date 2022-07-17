using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody r;
    public float speed = 10;
    float p = 1.5f;
    float l = 0;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (z > 0)
        {
            speed = 15;
        }
        else if (z < 0)
        {
            speed = 5;
        }
        else {
            speed = 10;
        }
        
        r.velocity = new Vector3(x * 8,r.velocity.y,speed);
        if (this.transform.position.y < -2) {
            GameObject.Find("GM").GetComponent<GM>().GameOver();
        }
        if (Time.time >= l + p)
        {
            Vector3 f = new Vector3(0, 5, 0);
            r.AddForce(f, ForceMode.Impulse);
            l = Time.time;
        } 
    }
}
