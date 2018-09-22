using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public float randbolge, randbomb;
    public float zaman;
    public GameObject engel, engel1,engel2, engel3,engel4, engel5,engel6,engel7,engel8;
    public float randy;
    public GameObject engely,engely1;
	void Start () {
        randbolge = Random.Range(1, 3);
        randbomb = Random.Range(1, 3);
        randy = Random.Range(1, 3);
    }
	void Update () {
        zaman = zaman + 1;
        if (zaman >= 1800)
        {
            zaman = 0;
        }
        if (zaman == 0)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (zaman == 300)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (zaman == 600)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (zaman == 900)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (zaman == 1200)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (zaman == 1500)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (zaman == 1800)
        {
            randbolge = Random.Range(1, 3);
            randbomb = Random.Range(1, 3);
            randy = Random.Range(1, 3);
        }
        if (randy == 1)
        {
            engely.SetActive(true);
            engely1.SetActive(false);
        }
        if (randy == 2)
        {
            engely.SetActive(false);
            engely1.SetActive(true);
        }
        if (randbolge == 1&&randbomb==1)
        {
            engel.SetActive(false);
            engel1.SetActive(false);
            engel2.SetActive(false);
            engel3.SetActive(false);
            engel4.SetActive(true);
            engel5.SetActive(true);
            engel6.SetActive(false);
            engel7.SetActive(true);
            engel8.SetActive(true);
        }
        if (randbolge == 1 && randbomb == 2)
        {
            engel.SetActive(false);
            engel1.SetActive(false);
            engel2.SetActive(false);
            engel3.SetActive(true);
            engel4.SetActive(false);
            engel5.SetActive(true);
            engel6.SetActive(true);
            engel7.SetActive(false);
            engel8.SetActive(true);
        }
        if (randbolge == 1 && randbomb == 3)
        {
            engel.SetActive(false);
            engel1.SetActive(false);
            engel2.SetActive(false);
            engel3.SetActive(true);
            engel4.SetActive(true);
            engel5.SetActive(false);
            engel6.SetActive(true);
            engel7.SetActive(true);
            engel8.SetActive(false);
        }
        if (randbolge == 2 && randbomb == 1)
        {
            engel.SetActive(false);
            engel1.SetActive(true);
            engel2.SetActive(true);
            engel3.SetActive(false);
            engel4.SetActive(false);
            engel5.SetActive(false);
            engel6.SetActive(false);
            engel7.SetActive(true);
            engel8.SetActive(true);
        }
        if (randbolge == 2 && randbomb == 2)
        {
            engel.SetActive(true);
            engel1.SetActive(false);
            engel2.SetActive(true);
            engel3.SetActive(false);
            engel4.SetActive(false);
            engel5.SetActive(false);
            engel6.SetActive(true);
            engel7.SetActive(false);
            engel8.SetActive(true);
        }
        if (randbolge == 2 && randbomb == 3)
        {
            engel.SetActive(true);
            engel1.SetActive(true);
            engel2.SetActive(false);
            engel3.SetActive(false);
            engel4.SetActive(false);
            engel5.SetActive(false);
            engel6.SetActive(true);
            engel7.SetActive(true);
            engel8.SetActive(false);
        }
        if (randbolge == 3 && randbomb == 1)
        {
            engel.SetActive(false);
            engel1.SetActive(true);
            engel2.SetActive(true);
            engel3.SetActive(false);
            engel4.SetActive(true);
            engel5.SetActive(true);
            engel6.SetActive(false);
            engel7.SetActive(false);
            engel8.SetActive(false);
        }
        if (randbolge == 3 && randbomb == 2)
        {
            engel.SetActive(true);
            engel1.SetActive(false);
            engel2.SetActive(true);
            engel3.SetActive(true);
            engel4.SetActive(false);
            engel5.SetActive(true);
            engel6.SetActive(false);
            engel7.SetActive(false);
            engel8.SetActive(false);
        }
        if (randbolge == 3 && randbomb == 3)
        {
            engel.SetActive(true);
            engel1.SetActive(true);
            engel2.SetActive(false);
            engel3.SetActive(true);
            engel4.SetActive(true);
            engel5.SetActive(false);
            engel6.SetActive(false);
            engel7.SetActive(false);
            engel8.SetActive(false);
        }
    }
}
