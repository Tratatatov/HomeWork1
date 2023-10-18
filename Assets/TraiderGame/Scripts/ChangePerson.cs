using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangePerson : MonoBehaviour
{
    [SerializeField] private UnityEvent changePerson;

    private void OnTriggerEnter(Collider other)
    {
        changePerson.Invoke();
        other.gameObject.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;

    }

}
