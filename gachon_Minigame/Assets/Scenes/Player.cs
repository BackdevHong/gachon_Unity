using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpPower = 5;
    private float speed = 2.0f;
    public float height = 1f;
    TextMesh scoreOutput;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreOutput = GameObject
            .Find(name: "Score")
            .GetComponent<TextMesh>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
        //transform.Translate(speed * Time.deltaTime, 0, 0);

        //if (transform.position.y < -3.0f)
        //{
        //    jumpPower = 10;
        //}
        //else
        //{
        //    jumpPower = 5;
        //}
    }


    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "점수 : " + score; 
    }

}
