using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressPlate : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update  
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isPressed", false);
    }
    // Update is called once per frame  
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isPressed", true);
        }
    }
}
