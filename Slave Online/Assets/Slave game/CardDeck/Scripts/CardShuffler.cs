using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShuffler : MonoBehaviour
{
    CardDeck cardDeck;
    
    public void Shuffle()
    {
        while (cardDeck.cardList.Count > 0)
        {
            int randomIndex = Random.Range(0, cardDeck.cardList.Count);
            cardDeck.shuffledCardList.Add(cardDeck.cardList[randomIndex]);
            cardDeck.cardList.RemoveAt(randomIndex);
        }
    }
}
