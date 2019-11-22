using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MidiJack;

public class ChangeCubeSize : MonoBehaviour
{
    private int noteNumber;


    void Start()
    {
        noteNumber = 30;
    }
    void Update()
    {
        transform.localScale = Vector3.one * (0.1f + MidiMaster.GetKey(noteNumber));

        var color = MidiMaster.GetKeyDown(noteNumber) ? Color.red : Color.white;
        GetComponent<Renderer>().material.color = color;
    }
}
