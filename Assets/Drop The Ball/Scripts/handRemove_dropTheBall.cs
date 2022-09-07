using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handRemove_dropTheBall : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
