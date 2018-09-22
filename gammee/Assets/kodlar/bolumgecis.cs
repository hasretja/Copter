using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolumgecis : MonoBehaviour {
    public void buton()
    {
        Application.LoadLevel(this.gameObject.name);
    }
    public void kapat()
    {
        Application.Quit();
    }
}
