using UnityEngine;
using System.Collections;

public class NoteIndicator : MonoBehaviour
{
    public int channel = 16;
    public int noteNumber;

    void Update ()
    {
        transform.localScale = Vector3.one * (0.1f + MidiInput.GetKey (channel, noteNumber));
        renderer.material.color = MidiInput.GetKeyDown (channel, noteNumber) ? Color.red : Color.white;
    }
}
