using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FraseController : MonoBehaviour
{
    public string[] _frases;
    List<int> _numFrase;
    public TextMeshProUGUI _text;
    public Material _shader;

    private int _showNumFrase, _newNum;
    private bool _activador;
    private float _fade;

    private void Start()
    {
        _showNumFrase = 0;
        _numFrase = new List<int>();
        Seleccionador();
    }

    private void Update()
    {
        MostradorDeFrases();
    }

    void Seleccionador()
    {
        for (int i = 0; i < _frases.Length; i++)
        {
            _newNum = Random.Range(0, _frases.Length);

            if(!_numFrase.Contains(_newNum))
                _numFrase.Add(_newNum);
            else
                i--;
        }
    }

    void MostradorDeFrases()
    {
        _shader.SetFloat("_Fade", _fade);

        if (_activador)
        {
            _fade = (_fade < 1) ? _fade += Time.deltaTime / 2 : _fade = 1;

            if (_fade == 1)
            {
                if (_showNumFrase != 0 && _showNumFrase <= _frases.Length)
                {
                    _text.text = _frases[_numFrase[_showNumFrase - 1]];
                }
                _activador = false;
            }
        }
        else
        {
            _fade = (_fade > 0) ? _fade -= Time.deltaTime / 2 : _fade = 0;
        }
    }

    #region Buttons
    public void Next()
    {
        _showNumFrase++;
        _activador = true;
    }
    #endregion
}
