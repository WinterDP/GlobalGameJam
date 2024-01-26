using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New card", menuName = "Card")]
public class CardSO : ScriptableObject
{
    [SerializeField]
    private string _cardName;
    public string CardName
    {
        get => _cardName;
    }

    [SerializeField]
    private string _cardDescription;
    public string CardDescription
    {
        get => _cardDescription;
    }

    [SerializeField]
    private int _cardPower;
    public int CardPower
    {
        get => _cardPower;
    }

    [SerializeField]
    private EnumCardThema _cardThema;
    public EnumCardThema CardThema
    {
        get => _cardThema;
    }

    [SerializeField]
    private EnumCardStructure _cardStructure;
    public EnumCardStructure CardStructure
    {
        get => _cardStructure;
    }

    [SerializeField]
    private Sprite _cardImage;
    public Sprite CardImage
    {
        get => _cardImage;
    }

    [SerializeField]
    private EnumCardThema _cardNewMood;
    public EnumCardThema CardNewMood
    {
        get => _cardNewMood;
    }

}

public enum EnumCardThema
{
    FALSE,
    HAIR,
    FUTBALL,
    FAMILY,
    NATIONALITY,
    JOKER
}

public enum EnumCardStructure
{
    INTRO,
    BUILDUP,
    PUNCHLINE
}
