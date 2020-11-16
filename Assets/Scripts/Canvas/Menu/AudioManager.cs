using UnityEngine;

public class AudioManager : MonoBehaviour {

    private static AudioManager _audioScript;

	void Awake()
    {
        if (_audioScript == null)
        {
            _audioScript = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }
}