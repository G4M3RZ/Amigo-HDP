using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    [Range(0, 1)]
    public float _speed = 0.5f;
    private Image _image;
    private Color _fadeColor;

	void Awake ()
    {
        _image = GetComponent<Image>();
        _fadeColor = Color.black;
        _fadeColor.a = 1;
        _image.color = _fadeColor;
    }

    public void Update()
    {
        _fadeColor.a = (_fadeColor.a > 0) ? _fadeColor.a -= Time.deltaTime * _speed : _fadeColor.a = 0;
        _image.color = _fadeColor;

        if (_fadeColor.a == 0)
            Destroy(this.gameObject);
    }
}