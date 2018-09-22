using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerhareket : MonoBehaviour {
    public Rigidbody rig;
    public GameObject player;
    public int sure;
    public int skor;
    public Text skorbord;
    public Text finalscore;
    public Text best;
    public GameObject info1, info2,panel;
    void Start () {
        rig = GetComponent<Rigidbody>();
        Time.timeScale = 0;
    }
    public void sagbuton()
    {       
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rig.velocity = new Vector3(40 * Time.deltaTime, 200 * Time.deltaTime, 0);
        player.transform.localScale = new Vector3(1, 1);
        Time.timeScale = 1;
        info1.SetActive(false);
        info2.SetActive(false);
    }
	public void solbuton()
    {
        rig.velocity = new Vector3(-40 * Time.deltaTime, 200 * Time.deltaTime, 0);
        player.transform.localScale = new Vector3(-1, 1);
        Time.timeScale = 1;
        info1.SetActive(false);
        info2.SetActive(false);
    }
    public void resetbutton()
    {
        Application.LoadLevel(name = "1");
    }
    void Update()
    {
        if (Time.timeScale == 1)
        {
            sure = sure + 1;
        }
        skor = sure / 10;
        skorbord.text = skor.ToString();
        finalscore.text = skor.ToString();
        if(skor > PlayerPrefs.GetFloat("best"))
        {
            PlayerPrefs.SetFloat("best", skor);
        }
        best.text = PlayerPrefs.GetFloat("best").ToString();
    }
}
