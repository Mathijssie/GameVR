using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnterCheck : MonoBehaviour
{
    public int muntjeslvl1 = 0;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        muntjeslvl1++;
        Debug.Log("Ik ben triggered");

        if (muntjeslvl1 == 2)
        {
            Debug.Log("Genoeg munten");
            SceneManager.LoadScene("level 2 game");
            Debug.Log("Naar volgend level");
        }
    }
}
