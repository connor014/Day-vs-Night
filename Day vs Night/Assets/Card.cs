using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ensures that the class is accessable through the asset menu. 
[CreateAssetMenu(fileName = "New Card", menuName = "cardTemplate")]

// Creates the class that will act as a template for each card. Added by Connor.
public class Card : ScriptableObject {

    /* Store card values. */

    // Stores the name of the card.
    public string cardName;
        
    // Stores the description of the card.
    public string description;

    // Stores the artwork of the card. 
    public Sprite artwork;

    // Stores the attack value of the card.
    public int attack;

    // Stores the defence value of the card. 
    public int defence;

    //
    public void Print ()
    {
        Debug.Log(cardName + ":" + description + "The card has:" + attack + "attack." + "The card has:" + defence + "defence.");
    }

}
