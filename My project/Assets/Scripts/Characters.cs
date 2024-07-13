﻿using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour
{
    public CharacterPosition Position { get; private set; }
    public CharacterName Name { get; private set; }
    public CharacterMood Mood { get; private set; }
    public bool IsShowing { get; private set; }

    private CharacterMoods _moods;

    private float _offScreenX;
    private float _onScreenX;

    private readonly float _animationSpeed = 1/6f;

    public void Init(CharacterName name, CharacterPosition position, CharacterMood mood, CharacterMoods moods)
    {
        Name = name;
        Position = position;
        Mood = mood;

        _moods = moods;

        Show();
    }

    public void Show()
    {
        SetAnimationValues();

        // Position outside of the screen
        transform.position = new Vector3(_offScreenX, transform.position.y, transform.localPosition.z);

        UpdateSprite();

        LeanTween.moveX(gameObject, _onScreenX, _animationSpeed).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = true;
        });
    }
    public void Hide()
    {
        LeanTween.moveX(gameObject, _offScreenX, _animationSpeed).setEase(LeanTweenType.linear).setOnComplete(() =>
        {
            IsShowing = false;
        });
    }

    public void ChangeMood(CharacterMood mood)
    {
        Mood = mood;
        UpdateSprite();
    }

    private void UpdateSprite()
    {
        var sprite = _moods.GetMoodSprite(Mood);
        var image = GetComponent<Image>();

        image.sprite = sprite;
        image.preserveAspect = true;
    }

    private void SetAnimationValues()
    {
        switch (Position)
        {
            case CharacterPosition._1_2:
                _onScreenX = Screen.width * 1/2f;
                _offScreenX = -Screen.width * 1/5f;
                break;

            case CharacterPosition._1_5:
                _onScreenX = Screen.width * 1/6f;
                _offScreenX = -Screen.width * 1/5f;
                break;

            case CharacterPosition._4_5:
                _onScreenX = Screen.width * 5/6f;
                _offScreenX = Screen.width * 6/5f;
                break;
        }
    }
}