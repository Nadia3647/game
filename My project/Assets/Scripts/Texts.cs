using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class Texts : MonoBehaviour
{
    private Story _story;
    private TextAsset _inkJson;
    private GameObject _textPanel;
    private GameObject _namePanel;
    [HideInInspector] public GameObject choicePanel;
    private TextMeshProUGUI _mainText;
    private TextMeshProUGUI _nameText;
    private GameObject _choiceButton;
    private List<TextMeshProUGUI> _choiceTexts = new();
    public bool TextOn { get; private set; }

    [Inject]
    public void Construct(TextInstaller textInstaller)
    {
        _inkJson = textInstaller.inkJson;
        _textPanel = textInstaller.textPanel;
        _namePanel = textInstaller.namePanel;
        choicePanel = textInstaller.choicePanel;
        _mainText = textInstaller.mainText;
        _nameText = textInstaller.nameText;
        _choiceButton = textInstaller.choiceButton;
    }

    private void Awake()
    {
        _story = new Story(_inkJson.text);
    }

    void Start()
    {
        StartCoroutine(WaitForCharacterName());
    }

    private IEnumerator WaitForCharacterName()
    {
        while (string.IsNullOrEmpty(EnterName.charaterName))
        {
            yield return null;
        }

        _story.variablesState["mainName"] = EnterName.charaterName;
        StartText();
    }

    public void StartText()
    {
        TextOn = true;
        _textPanel.SetActive(true);
        NextText();
    }

    public void NextText(bool choiceOn = false)
    {
        if (EnterName.check == 1) // Проверяем значение переменной check
        {
            if (_story.canContinue)
            {
                ShowText();
                ShowButtons();
            }
            else if (!choiceOn)
            {
                EndText();
            }
        }
    }

    public void ShowText()
    {
        _nameText.text = (string)_story.variablesState["speakerName"];
        if (_nameText.text != "") { _namePanel.SetActive(true); }
        else { _namePanel.SetActive(false); }
        _mainText.text = _story.Continue();
    }

    public void ShowButtons()
    {
        List<Choice> choices = _story.currentChoices;
        choicePanel.SetActive(choices.Count != 0);
        if (choices.Count == 0) { return; }
        for (int i = 0; i < choices.Count; i++)
        {
            GameObject button = Instantiate(_choiceButton);
            button.GetComponent<ButtonActions>().index = i;
            button.transform.SetParent(choicePanel.transform);
            TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = choices[i].text;
            _choiceTexts.Add(buttonText);
        }
    }

    public void ButtonAction(int choiceIndex)
    {
        _story.ChooseChoiceIndex(choiceIndex);
        NextText(true);
    }

    public void EndText()
    {
        TextOn = false;
        _textPanel.SetActive(false);
    }
}
