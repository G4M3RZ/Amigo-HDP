using UnityEngine;

public class SceneController : MonoBehaviour
{
    public GameObject _fade;
    private bool _active;

    public void NewScene(string sceneName)
    {
        if(_active == false)
        {
            _active = true;
            GameObject fade = Instantiate(_fade, transform.parent);
            fade.GetComponent<FadeOut>()._sceneName = sceneName;
        }    
    }
}