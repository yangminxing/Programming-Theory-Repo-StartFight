using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemyBehavier : AbstractUnit
{
    public GameObject primaryFireObject;
    public GameObject secondaryFireObject;
    private float fireInterval = 2f;

    private GameObject player;

    private float spwanYPos = 6;
    private float spwanXMaxPos;
    private float spwanXMinPos;

    private float moveSpeed = 0.7f;

    private void Awake()
    {
        spwanXMinPos = moveWBoundry;
        spwanXMaxPos = moveEBoundry;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameManager.instance.player;

        Spwan();

        StartCoroutine(FireRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();

        DestoryOutBoundry();
    }

    protected void Spwan() {
        transform.position = new Vector3(Random.Range(spwanXMinPos, spwanXMaxPos), spwanYPos);
        transform.Rotate(Vector3.forward, 180);
    }

    protected void MoveForward() {

        transform.transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
    }

    protected IEnumerator FireRoutine() {
        while (true) {
           yield return new WaitForSeconds(fireInterval);

            FireOnce(primaryFireObject);
        }
    }

    protected void FireOnce(GameObject fireOjbect) {
        FireBehavier fireBehavier = Instantiate(fireOjbect, gameObject.transform.position, fireOjbect.transform.rotation).GetComponent<FireBehavier>();
        fireBehavier.SetSourceAndTarget(gameObject.GetComponent<AbstractEnemyBehavier>(), player.GetComponent<PlayerBehavier>());
    }

    protected void FireTwice(GameObject fireOjbect) { 
    
    }

    protected void FIreTwiceRapidly(GameObject fireOjbect) { 
    
    }
}
