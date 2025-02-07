using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TMP_InputField textInput;
    [SerializeField] TMP_Text titleText;
    [SerializeField] TMP_Text Lives;
    [SerializeField] int HP = 3;
    [SerializeField] int numG;
    [SerializeField] bool Win = false;
    //[SerializeField]
    void Start()
    {
        gameStart();

    }
    void gameStart()
    {
        numG = Random.Range(1, 10);
        textInput.text = "";
        titleText.text = "Guess a Number \r\nfrom 1-10!!!";
        HP = 3;
        Lives.text = HP.ToString();
        Win = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
        {
            titleText.text = "Oh No!! You have run out of Lives!! The Correct answer was " + numG + ". Better luck next time. Click Restart to try again.";
            textInput.text = "";
        }
        if (Win == true)
        {
            titleText.text = "You did it " + numG + " was the correct number!!! Click Restart to Play again.";
            textInput.text = "";
        }
    }

    void LiveDrop()
    {
        HP--;
        Lives.text = HP.ToString();

    }
    public void Guess()
    {

        if (HP > 0 && textInput.text != "")
        {
            if (int.Parse(textInput.text) == numG)
            {
                Win = true;
            }
            else
            {
                titleText.text = "Nope! That was wrong, try again...";
                LiveDrop();
                textInput.text = "";
            }
        }
    }
    public void restart()
    {
        gameStart();
    }


}
