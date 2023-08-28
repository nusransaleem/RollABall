using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    Renderer rend;
    float duration = 1.0f;
    public Color targetColor;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        rend.material.color = Color.Lerp(Color.white, targetColor, lerp);
    }
}
