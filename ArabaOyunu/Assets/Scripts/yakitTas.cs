using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yakitTas : MonoBehaviour
{
    public GameObject yakitText;
    private TextMesh yakitTextMesh;
    public GameObject sureText;
    private TextMesh sureTextMesh;
    float yakitDegeri = 100f;
    int sure = 0;

    void Start()
    {
        PlayerPrefs.SetFloat("Yakit", yakitDegeri);
        yakitTextMesh = yakitText.GetComponent<TextMesh>();
        sureTextMesh = sureText.GetComponent<TextMesh>();
        InvokeRepeating("yakitAzalt", 10f, 5f);
        InvokeRepeating("sureArttir", 1f, 1f);
    }

    void Update()
    {
        if (yakitDegeri <= 0)
        {
            Time.timeScale = 0f;
        }
    }

    void yakitAzalt()
    {
        yakitDegeri -= Random.Range(2f, 5f);
        yakitDegeri = Mathf.Round(yakitDegeri * 10.0f) * 0.1f;
        PlayerPrefs.SetFloat("Yakit", yakitDegeri);
        yakitTextMesh.text = "Yakýt: " + yakitDegeri;
    }

    void sureArttir()
    {
        sure++;
        sureTextMesh.text = "Süre: " + sure;
    }
}
