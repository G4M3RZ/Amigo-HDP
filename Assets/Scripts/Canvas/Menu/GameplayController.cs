using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
    public GameObject _fade;
    private AudioSource _soundTrack;
    
    private string _newSceneName;

    private bool _lock;
    [Range(0,5)]
    public float _timer;
    private float _time;

    private void Start()
    {
        _time = _timer;
        _lock = false;
        _soundTrack = GameObject.Find("SoundTruck").GetComponent<AudioSource>();
    }

    private void Update()
    {
        CambioDeScena();
    }

    void CambioDeScena()
    {
        if (_newSceneName != null)
        {
            if (_lock)
            {
                Instantiate(_fade, transform.position, transform.rotation);
                _lock = false;
            }

            if (_time <= 0)
                SceneManager.LoadScene(_newSceneName);
            else
                _time -= Time.deltaTime;
        }
    }

    #region Buttons
    public void ChangeScene(string _sceneName)
    {
        _newSceneName = _sceneName;
        _lock = true;
    }

    public void Mute()
    {
        if(_soundTrack.volume != 0)
        {
            _soundTrack.volume = 0;
        }
        else
        {
            _soundTrack.volume = 1;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    #endregion
}
