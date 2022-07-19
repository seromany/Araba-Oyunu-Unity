using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuel : MonoBehaviour
{
    public GameObject yakitText;
    private TextMesh yakitTextMesh;
    float yakitDegeri;

    void Start()
    {
        yakitText = GameObject.Find("yakitText");
        yakitTextMesh = yakitText.GetComponent<TextMesh>();
    }

    void OnTriggerEnter(Collider go)
    {
        if (go.gameObject.name == "Free Racing Car")
        {
            yakitDegeri = PlayerPrefs.GetFloat("Yakit");
            if(yakitDegeri <= 97)
            {
                yakitDegeri += 3f;
                yakitDegeri = Mathf.Round(yakitDegeri * 10.0f) * 0.1f;
                PlayerPrefs.SetFloat("Yakit", yakitDegeri);
                yakitTextMesh.text = "Yakýt: " + yakitDegeri;
            }
            
        }
    }
}
