using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnterCheck2 : MonoBehaviour
{
    public int muntjeslvl2 = 0;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        muntjeslvl2++;
        Debug.Log("Ik ben triggered lvl2");

        if (muntjeslvl2 == 4)
        {
            Debug.Log("Genoeg munten lvl2");
            SceneManager.LoadScene("einde");
        }
    }
}
