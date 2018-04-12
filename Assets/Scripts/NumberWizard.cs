using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    public int maxGuessesAllowed = 10;

    public Text text;

    void Start()
    {
        StartGame();


    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        //guess = 500;
        NextGuess();

        //max = max + 1;
        if (false)
            print("stupid");
    }


    /*void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Down arrow pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            print("Play Again.");
            StartGame();
        }
        
    }*/

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();
        //print("Is the number higher or lower that " + guess + "?");
        //print("Up = higher, down = lower, return = equal");
        maxGuessesAllowed = maxGuessesAllowed - 1;
        if(maxGuessesAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
}
