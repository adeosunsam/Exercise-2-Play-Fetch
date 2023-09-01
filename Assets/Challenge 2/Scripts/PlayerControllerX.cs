using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnTimerMax = 1.2f;
    //set default dog spawn timer for the first time
    private float spawnTimer = 2f;

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnTimer > spawnTimerMax)
            {
                //reset timer to zero
                spawnTimer = 0;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
