using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleBulletPrefab : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Eliminator")
        {
            Destroy(this.gameObject);
        }
    }
}
