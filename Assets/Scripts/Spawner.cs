using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Cheese _prefabCheese;
    [SerializeField] float _timeSpawn;
    [SerializeField] private int _disp;


    private float _timer;
    private float posX, posY, posZ;

    private void Start()
    {
        posX = transform.position.x;
        posY = transform.position.x;
        posZ = transform.position.z;
        SpawnItem();
    }

    private void FixedUpdate()
    {
        _timer += Time.deltaTime;

        if (_timer >= _timeSpawn)
        {
            SpawnItem();
            _timer = 0f;
        }
    }

    private void SpawnItem()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(posX - _disp, posX + _disp), posY, Random.Range(posZ - _disp, posZ + _disp));
        Instantiate(_prefabCheese, spawnPosition, Quaternion.identity);
    }
}
