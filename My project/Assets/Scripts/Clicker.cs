using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Clicker : MonoBehaviour, Controls.ITurntextActions
{
    Controls _input;
    Texts _texts;

    private void OnEnable()
    {
        _texts = FindObjectOfType<Texts>();
        if (_input != null) { return; }
        _input = new Controls();
        _input.Turntext.SetCallbacks(this);
        _input.Turntext.Enable();
    }

    private void OnDisalbe()
    {
        _input.Turntext.Disable();
    }

    public void OnNextPhrase(InputAction.CallbackContext context)
    {
        if (context.canceled && _texts.TextOn)
        {
            _texts.NextText(_texts.choicePanel.activeInHierarchy);
        }
    }
}
