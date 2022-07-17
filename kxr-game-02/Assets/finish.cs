using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("GM").GetComponent<GM>().Finish();
    }
}
