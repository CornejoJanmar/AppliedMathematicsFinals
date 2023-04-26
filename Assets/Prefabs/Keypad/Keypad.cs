using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    // Set a password
    public string password = "1234";
    private string userInput = "";

    public void ButtonClicked(string number)
    {
        // Check if button's being clicked
        Debug.Log($"Clicked {number}");
        userInput += number;
        if (userInput.Length >= 4)
        {
            // Password checker: runs once 4 digits are entered in userInput
            if (userInput == password)
            {
                Debug.Log("Entry Allowed");
            }
            else
            {
                Debug.Log("Nope.");
                userInput = "";
            }
        }
    }

    private void Start()
    {
        // Upon starting, it empties the userInput
        userInput = "";
    }

    void Update()
    {
        
    }
}
