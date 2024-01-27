using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckPoint : MonoBehaviour
{

    [SerializeField] Vector3 vectorPoint;
    [SerializeField] float dead;
    [SerializeField] private float _ballSpeed;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float Horizontal;
    [SerializeField] private float Vertical;
    [SerializeField] private float rotationSpeed;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (transform.position.y < -dead)
        {
            transform.position = vectorPoint;
        }
        Move();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("next"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.gameObject.CompareTag("Check"))
        {
            other.gameObject.SetActive(false);
            vectorPoint = transform.position;
        }

    }
    private void Move()
    {
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");


            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.up * (-rotationSpeed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
            }

            transform.Translate(new Vector3(0f, 0, moveVertical * _ballSpeed * Time.deltaTime), Space.Self);
        }



    }
}
