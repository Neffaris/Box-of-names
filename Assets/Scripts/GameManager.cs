using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Name_text;
    string[] _names;

    private void Start()
    {
        _names = new string[]
        {
            "Krzysztof", "Agnieszka", "Kacper", "Pawe³", "Piotr", "Jakub", "Zuzanna", "Ania", "Kasia", "Marcelina", "Izabela", "Agata", "Monika", "Tomek", "Mateusz", "Danuta", "Leokadia", "Kamil", "Albert", "Andrzej"
        };
    }

    int DrawNumber()
    {
        int  _randomNumber = Random.Range(0, _names.Length);
        return _randomNumber;
    }

    public void DrawName()
    {
        string name = _names[DrawNumber()];
        Name_text.text = name;
    }
}
