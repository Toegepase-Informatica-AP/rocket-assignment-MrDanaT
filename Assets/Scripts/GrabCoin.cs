using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabCoin : MonoBehaviour
{
    public Text score;

    private void Start()
    {
        if (score == null)
        {
            score = Text.FindObjectOfType<Text>();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (int.TryParse(score.text, out int scoreParsed))
            {
                score.text = (scoreParsed + 1).ToString();
            }
            if (scoreParsed == 3)
            {
                score.text = "You won!";
            }
        }

    }
}
