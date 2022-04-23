using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text _textCurrency;

    private int _counter;    
    public int CounterCoins { get => _counter; }

    public void AddCoins(int x)
    {
        _counter += x;
        UpdateTextOnUI();
    }

    private void UpdateTextOnUI()
    {
        _textCurrency.text = _counter.ToString();
    }

}
