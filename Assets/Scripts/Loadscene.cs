using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Loadscene : MonoBehaviour
{
    public void esenacarga(string a)
    {
        SceneManager.LoadScene(a);
    }
}
