using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShuffler : MonoBehaviour
{
    CardDeck cardDeck;

    System.Random random = new System.Random();
    
    public void Shuffle<T>(List<T> deck)
    {
        for (int card = deck.Count; card > 1; card--)
        {
            int swapIndex = random.Next(card);
            T temp = deck[swapIndex];
            deck[swapIndex] = deck[card];
            deck[card] = temp;
        }
    }
}
