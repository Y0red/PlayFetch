using System.Collections;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField]float time = 5f;
    [SerializeField]bool canSpawn = true;
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(CalculateSpawnTime());
        }
    }

    IEnumerator CalculateSpawnTime()
    {
        canSpawn = false;
        yield return new WaitForSeconds(time);
        canSpawn = true;
    }
}
