using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;
using Assets.Scripts;
using UnityEngine.TextCore.Text;

public class CharacterManager : MonoBehaviour
{
    private List<Characters> _characters;

    [SerializeField]
    private GameObject _characterPrefab;

    [SerializeField]
    private CharacterMoods _Main;
    [SerializeField]
    private CharacterMoods _Grandpa;
    [SerializeField]
    private CharacterMoods _Grandma;
    [SerializeField]
    private CharacterMoods _Raven;
    [SerializeField]
    private CharacterMoods _Dragon;
    [SerializeField]
    private CharacterMoods _Aisha;
    [SerializeField]
    private CharacterMoods _Archi;
    [SerializeField]
    private CharacterMoods _Emmet;

    private void Start()
    {
        _characters = new List<Characters>();
    }

    public void ShowCharacter(string name, string position, string mood)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to enum: {name}");
            return;
        }

        if (!Enum.TryParse(position, out CharacterPosition positionEnum))
        {
            Debug.LogWarning($"Failed to parse character position to enum: {position}");
            return;
        }

        if (!Enum.TryParse(mood, out CharacterMood moodEnum))
        {
            Debug.LogWarning($"Failed to parse character mood to enum: {mood}");
            return;
        }

        ShowCharacter(nameEnum, positionEnum, moodEnum);
    }

    public void ShowCharacter(CharacterName name, CharacterPosition position, CharacterMood mood)
    {
        var character = _characters.FirstOrDefault(x => x.Name == name);

        if (character == null)
        {
            var characterObject = Instantiate(_characterPrefab, gameObject.transform, false);
            character = characterObject.GetComponent<Characters>();

            _characters.Add(character);
        }
        else if (character.IsShowing)
        {
            Debug.LogWarning($"Failed to show character {name}. Character already showing");
            return;
        }

        character.Init(name, position, mood, GetMoodSetForCharacter(name));
    }

    public void HideCharacter(string name)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }

        HideCharacter(nameEnum);
    }

    public void HideCharacter(CharacterName name)
    {
        var character = _characters.FirstOrDefault(x => x.Name == name);

        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't hide it.");
            return;
        }
        else
        {
            character.Hide();
        }
    }
    public void ChangeMood(string name, string mood)
    {
        if (!Enum.TryParse(name, out CharacterName nameEnum))
        {
            Debug.LogWarning($"Failed to parse character name to character enum: {name}");
            return;
        }

        if (!Enum.TryParse(mood, out CharacterMood moodEnum))
        {
            Debug.LogWarning($"Failed to parse character mood to enum: {mood}");
            return;
        }

        ChangeMood(nameEnum, moodEnum);
    }

    public void ChangeMood(CharacterName name, CharacterMood mood)
    {
        var character = _characters.FirstOrDefault(x => x.Name == name);

        if (character?.IsShowing != true)
        {
            Debug.LogWarning($"Character {name} is not currently shown. Can't change the mood.");
            return;
        }
        else
        {
            character.ChangeMood(mood);
        }
    }

    private CharacterMoods GetMoodSetForCharacter(CharacterName name)
    {
        switch (name)
        {
            case CharacterName.main:
                return _Main;
            case CharacterName.grandpa:
                return _Grandpa;
            case CharacterName.grandma:
                return _Grandma;
            case CharacterName.raven:
                return _Raven;
            case CharacterName.dragon:
                return _Dragon;
            case CharacterName.Aisha:
                return _Aisha;
            case CharacterName.Archi:
                return _Archi;
            case CharacterName.Emmet:
                return _Emmet;
            default:
                Debug.LogError($"Could not find moodset for {name}");
                return null;
        }
    }
}