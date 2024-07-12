using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

    private CharacterManager _characterManager;

    private void Awake()
    {
        _story = new Story(_inkJson.text);
    }

    void Start()
    {
        _characterManager = FindObjectOfType<CharacterManager>();
        StartText();
    }

    public void StartText()
    {
        _story.BindExternalFunction("Show",
            (string name, string position, string mood) => _characterManager.ShowCharacter(name, position, mood));

        _story.BindExternalFunction("Hide",
            (string name) => _characterManager.HideCharacter(name));

        TextOn = true;
        _textPanel.SetActive(true);
        NextText();
    }

    public void NextText(bool choiceOn = false)
    {
        if (_story.canContinue)
        {
            ShowText();
            ShowButtons();
        }
        else if(!choiceOn)
        {
            EndText();
        }
    }

    public void ShowText()
    {
        _mainText.text = _story.Continue();
        _nameText.text = (string)_story.variablesState["speakerName"];
        if (_nameText.text != "") { _namePanel.SetActive(true); }
        else { _namePanel.SetActive(false); }
    }

    public void ShowButtons()
    {
        List<Choice> choices = _story.currentChoices;
        choicePanel.SetActive(choices.Count != 0);
        if (choices.Count == 0) { return; }
        _textPanel.SetActive(false);
        choicePanel.transform.Cast<Transform>().ToList().ForEach(child => Destroy(child.gameObject));
        _choiceTexts.Clear();
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
        _textPanel.SetActive(true);
        NextText(true);
    }

    public void EndText()
    {
        TextOn = false;
        _textPanel.SetActive(false);
    }
}