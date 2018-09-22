using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmany : MonoBehaviour {
    public int yh;
    public GameObject engel;
    public GameObject panel;
    void Start () {
        yh = 3;
        Time.timeScale = 0;
    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Finish")
        {
            yh = -yh;
            float y = Input.GetAxis("Vertical");
            transform.Translate(0, yh * Time.deltaTime, 0);
            engel.transform.localScale = new Vector3(1, -1);
        }
        if (coll.tag == "finish")
        {
            yh = -yh;
            float y = Input.GetAxis("Vertical");
            transform.Translate(0, yh * Time.deltaTime, 0);
            engel.transform.localScale = new Vector3(1, 1);
        }
        if (coll.tag == "Player")
        {
            Time.timeScale = 0;
            panel.SetActive(true);

        }
    }
    void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        engel.transform.Translate(0, yh * Time.deltaTime, 0);
    }
}
