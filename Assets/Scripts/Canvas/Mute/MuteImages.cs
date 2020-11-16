using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteImages : MonoBehaviour
{
    public List<Sprite> _icons;
    public List<Color> _color;
    private AudioSource _audio;
    private Image _icon;

    private void Awake()
    {
        _audio = GameObject.FindGameObjectWithTag("SoundTruck").GetComponent<AudioSource>();
        _icon = GetComponent<Image>();
        SetIcons();
    }
    void SetIcons()
    {
        int currentNum = (_audio.mute) ? 1 : 0;
        _icon.sprite = _icons[currentNum];
        _icon.color = _color[currentNum];
    }
    public void MuteButton ()
    {
        _audio.mute = !_audio.mute;
        SetIcons();
    }
}