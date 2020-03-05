using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

    public Material ColorInicial;
    [Range(0,1)]
    public float Speed = 0.5f;

    private float alpha = 0f;

    void Start()
    {
        alpha = 0f;
        gameObject.GetComponent<SpriteRenderer>().material = ColorInicial;
        ColorInicial.color = new Color(0, 0, 0, alpha);
    }

    public void Update()
    {
        gameObject.GetComponent<SpriteRenderer>().material = ColorInicial;
        ColorInicial.color = new Color(0, 0, 0, alpha);
        alpha = (alpha < 1) ? alpha += Speed * Time.deltaTime : alpha = 1;
    }
}
