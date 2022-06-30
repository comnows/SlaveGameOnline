using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDealOut : MonoBehaviour
{
    PlayerHand[] playerHands;

    private void Start() 
    {
        playerHands = FindObjectsOfType<PlayerHand>();
    }
    
    public void DealAllCard()
    {
        int amountOfCardToDraw = GetAmountOfCard();
        
        for(int round = 0; round < amountOfCardToDraw; round++)
        {
            for(int player = 0; player < playerHands.Length; player++)
            {
                playerHands[player].handCard.Add(CardDeck.Instance.deckList[0]);
                CardDeck.Instance.deckList.RemoveAt(0);
            }
        }
    }

    public int GetAmountOfCard()
    {
        int amount = CardDeck.Instance.deckList.Count / playerHands.Length;
        
        return amount;
    }
}
