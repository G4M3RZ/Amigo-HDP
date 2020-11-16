using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    public GameObject _fade;
    private MuteImages _muteController;
    
    private string _newSceneName;

    [Range(0,5)]
    public float _timer;
    private float _time;
    private bool _lock;

    private void Start()
    {
        _newSceneName = null;
        _time = _timer;
        _lock = false;
        _muteController = transform.GetChild(0).GetComponent<MuteImages>();
    }

    private void Update()
    {
        if(_newSceneName != null)
            CambioDeScena();
    }

    void CambioDeScena()
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

    #region Buttons
    public void ChangeScene(string _sceneName)
    {
        _newSceneName = _sceneName;
        _lock = true;
    }

    public void Mute(bool _isMuted)
    {
        
    }
    #endregion
}
