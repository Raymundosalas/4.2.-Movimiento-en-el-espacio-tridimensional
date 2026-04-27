using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public int totalPlatforms = 30;

    void Start()
    {
        for(int i = 0; i < totalPlatforms; i++)
        {
            Vector3 pos = new Vector3(
                Random.Range(-2f, 2f),
                i * 2f,
                Random.Range(-2f, 2f)
            );

            Instantiate(platformPrefab, pos, Quaternion.identity);
        }
    }
}
