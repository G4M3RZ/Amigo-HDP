using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class MuteImages : MonoBehaviour
{
    public List<GameObject> _muteImages;
    private AudioSource _audio;

    private void Start()
    {
        _muteImages = new List<GameObject>();

        for (int i = 0; i < 2; i++)
        {
            _muteImages.Add(transform.GetChild(i).gameObject);
        }

        #region SetAudioImages
        _audio = GameObject.FindGameObjectWithTag("SoundTruck").GetComponent<AudioSource>();

        bool _mute;

        if (_audio.volume == 0)
            _mute = true;
        else
            _mute = false;

        ChangeImages(_mute);
        #endregion
    }

    public void ChangeImages(bool _value)
    {
        if (_value)
            _audio.volume = 0;
        else
            _audio.volume = 1;

        _muteImages[0].SetActive(!_value);
        _muteImages[1].SetActive(_value);
    }
}
