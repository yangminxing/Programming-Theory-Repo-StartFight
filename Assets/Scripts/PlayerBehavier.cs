using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavier: AbstractUnit
{
    public GameObject primaryFireObject;

    private float moveSpeed = 10;
    private float fireInterval = 0.6f;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(FireRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        LimitBoundry();

        if (Input.GetKeyDown(KeyCode.Space)) {
            FireOnce(primaryFireObject);
        }
    }

    IEnumerator FireRoutine() {
        while (true)
        {
            yield return new WaitForSeconds(fireInterval);

            FireOnce(primaryFireObject);
        }
    }

    protected void FireOnce(GameObject fireOjbect)
    {
        FireBehavier fireBehavier1 = Instantiate(fireOjbect, gameObject.transform.position + new Vector3(0.12f, 0),
            fireOjbect.transform.rotation).GetComponent<FireBehavier>();
        fireBehavier1.MoveStraight();

        FireBehavier fireBehavier2 = Instantiate(fireOjbect, gameObject.transform.position + new Vector3(-0.12f, 0),
    fireOjbect.transform.rotation).GetComponent<FireBehavier>();
        fireBehavier2.MoveStraight();
    }

    void Move() {
        float hovInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        gameObject.transform.Translate(Vector3.right * Time.deltaTime * hovInput * moveSpeed);
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * verInput * moveSpeed);
    }



}
