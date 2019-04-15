using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardsDisplay : MonoBehaviour
{
    //
    public Card card;

    public Text nameText;
    public Text descriptionText;
    public Image artworkImage;
    public Text attackText;
    public Text defenceText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.cardName;
        descriptionText.text = card.description;
        artworkImage.sprite = card.artwork;
        attackText.text = card.attack.ToString();
        defenceText.text = card.defence.ToString();
    }
}
