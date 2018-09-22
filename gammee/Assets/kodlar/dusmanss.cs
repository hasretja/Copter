using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanss : MonoBehaviour {
    public int xh;
    public float sayac;
    public GameObject engel;
    public GameObject panel;
    void Start()
    {
        xh = 3;
        Time.timeScale = 0;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Finish")
        {
            xh = -xh;
            float y = Input.GetAxis("Vertical");
            transform.Translate(xh * Time.deltaTime, 0, 0);
            transform.localScale = new Vector3(-1, 1);

        }
        if (coll.tag == "finish")
        {
            xh = -xh;
            float y = Input.GetAxis("Vertical");
            transform.Translate(xh * Time.deltaTime, 0, 0);
            transform.localScale = new Vector3(1, 1);
            sayac = Random.Range(0, 5);
            if (sayac == 3)
            {
                engel.SetActive(false);
            }
        }
        if (coll.tag == "Player")
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(xh * Time.deltaTime, 0, 0);
    }
}
