using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tas : MonoBehaviour
{

    void OnTriggerEnter(Collider go)
    {
        if (go.gameObject.name == "Free Racing Car")
        {
            Time.timeScale = 0f;
        }
    }
}
