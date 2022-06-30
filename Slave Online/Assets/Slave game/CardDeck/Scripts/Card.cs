using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public enum Suit {Spades, Hearts, Diamonds, Clubs}

    [Header("Card Value")]
    public int value;
    public Suit suit;

    [Header("Card Sprite")]
    public Sprite CardFace;
    public Sprite CardBack;
}
