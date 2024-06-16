using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textVisual;
    public string text { get; private set; }
    private void Awake()
    {
        text = "Typer";
        textVisual.text = text;
    }
}
