using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public TextMeshProUGUI wordText; 
    public TextMeshProUGUI inputText; 
    private string targetWord = "apple";
    private string currentInput = "";

    private void Start()
    {
        wordText.text = targetWord;
        inputText.text = "";
    }
    private void Update()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // Backspace
            {
                if (currentInput.Length > 0)
                {
                    currentInput = currentInput.Substring(0, currentInput.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // Enter/Return
            {
                currentInput = ""; // Clear input on Enter
            }
            else
            {
                currentInput += c;
                CheckInput();
            }

            inputText.text = currentInput;
        }
    }
    void CheckInput()
    {
        if (currentInput == targetWord)
        {
            currentInput = ""; // Reset input after correct word
        }
    }
}
