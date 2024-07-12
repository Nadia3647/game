using Assets.Scripts;
using UnityEngine;

public class CharacterMoods : MonoBehaviour
{
    public CharacterName Name;

    public Sprite Fine;
    public Sprite GetMoodSprite(CharacterMood mood)
    {
        return Fine;
    }
}