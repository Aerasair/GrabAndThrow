using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    [SerializeField] private Counter _counter;

    private Cheese _currentCheese;

    private float hiegh = -2.73f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Cheese cheese) && _currentCheese == null)
        {
            _currentCheese = cheese;
            cheese.gameObject.transform.parent = gameObject.transform;
            cheese.gameObject.transform.localPosition = new Vector3(0, 1, 1);
        }

        if (other.gameObject.TryGetComponent(out Mouse mouse) && _currentCheese != null)
        {
            _counter.AddCoins(1);
            _currentCheese.gameObject.transform.parent = mouse.transform;
            hiegh += 0.2f;
            _currentCheese.transform.localPosition = new Vector3(-4.2f, hiegh, -0.43f);
            _currentCheese = null;
        }
    }
}
