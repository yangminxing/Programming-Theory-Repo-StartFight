using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public List<GameObject> enemyPrefabs;
    public GameObject player;

    private float enemySpwanInterval = 3;

    void Awake()
    {
        if (instance != null) {
            Destroy(gameObject);
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpwanTheEnemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpwanTheEnemy() {
        while (true) {
            yield return new WaitForSeconds(enemySpwanInterval);

            int enemyIndex = Random.Range(0, enemyPrefabs.Count);

            Instantiate(enemyPrefabs[enemyIndex]);
        }
    }
}
