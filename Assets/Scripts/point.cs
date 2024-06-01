using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour
{
    public GameObject bomb;
    private void Start()
    {
        Instantiate(bomb, transform.position, Quaternion.identity);
    }

}
