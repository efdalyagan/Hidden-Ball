using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public void SahneDegistir (int sahne_id){

        SceneManager.LoadScene(sahne_id);

    }
}

