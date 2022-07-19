using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadController : MonoBehaviour
{
    public GameObject fuel;
    public GameObject tas;
    GameObject car;
    public float[] konumlar = new float[] { -3f, 2f };
    public GameObject[] objeler = new GameObject[2];

    void Start()
    {
        car = GameObject.Find("Free Racing Car");
        objeler[0] = fuel;
        objeler[1] = tas;
    }

    void OnTriggerEnter(Collider obj)
    {
        float mesafe = car.transform.position.z;
        Vector3 pos = new Vector3(konumlar[Random.Range(0, 2)], 0.75f, Random.Range(mesafe * 5, mesafe * 7));
        Instantiate(objeler[Random.Range(0, 2)], pos, objeler[Random.Range(0, 2)].transform.rotation);
        transform.position += new Vector3(0, 0, transform.GetComponent<Renderer>().bounds.size.z*3);
    }
}
