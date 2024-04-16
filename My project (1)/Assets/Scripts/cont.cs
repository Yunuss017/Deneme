using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cont : MonoBehaviour
{
    [SerializeField]
    private GameObject bush;

    private void Start()
    {
        Debug.Log("WASD - Space - E");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //obje spawner
            Instantiate(bush, new Vector3(Random.Range(gameObject.transform.position.x - 3f, gameObject.transform.position.x + 3f), 0f, Random.Range(gameObject.transform.position.z - 3f, gameObject.transform.position.z + 3f)), Quaternion.Euler(0f, 0f, 0f), gameObject.transform);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObject.transform.childCount <= 0)
            {
                Debug.Log("Bomba");
            }
            else
            {
                //obje destroyer
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }
        }
        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 5f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * 5f);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * Time.deltaTime * 5f);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * 5f);
        }
    }
}
