using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{ 
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Enemy selectedEnemy;
    private string currentInput = "";
    private void Start()
    {
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
                Debug.Log(currentInput);

                CheckInput(currentInput.Length - 1);
            }
        }
    }
    private void CheckInput(int i)
    {
        if (currentInput[i] == selectedEnemy.text[i])
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        Bullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity).GetComponent<Bullet>();
        bullet.Initialize(selectedEnemy);
    }
}
