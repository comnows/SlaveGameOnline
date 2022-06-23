using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealOut : MonoBehaviour
{
    CardDeck cardDeck;
    PlayerHand[] playerHands;

    private void Start() 
    {
        cardDeck = GetComponent<CardDeck>();
        playerHands = FindObjectsOfType<PlayerHand>();
    }
    
    public void DealOut()
    {
        int amountOfCardToDraw = GetAmountOfCard();
        
        for(int round = 0; round < amountOfCardToDraw; round++)
        {
            for(int player = 0; player < playerHands.Length; player++)
            {
                playerHands[player].handCard.Add(cardDeck.deckList[0]);
                cardDeck.deckList.RemoveAt(0);
            }
        }
    }

    public int GetAmountOfCard()
    {
        int amount = cardDeck.deckList.Count / playerHands.Length;
        
        return amount;
    }
}
