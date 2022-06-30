using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    private static CardDeck _instance;
    public static CardDeck Instance { get; }

    public List<Card> deckList;

    private void Awake() 
    {
        _instance = this;
    }
}
