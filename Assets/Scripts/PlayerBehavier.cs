using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavier: AbstractUnit
{
    private float moveSpeed = 10;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Start!");
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        LimitBoundry();
    }

    void Move() {
        float hovInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");

        gameObject.transform.Translate(Vector3.right * Time.deltaTime * hovInput * moveSpeed);
        gameObject.transform.Translate(Vector3.up * Time.deltaTime * verInput * moveSpeed);
    }



}
