using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    public int index;
    private Button _button;
    private Texts _texts;
    private UnityAction _click;

    void Start()
    {
        _button = GetComponent<Button>();
        _texts = FindObjectOfType<Texts>();
        _click = new UnityAction(() => _texts.ButtonAction(index));
        _button.onClick.AddListener(_click);
    }
}
