using UnityEngine;
using System.Collections;

public class NoteIndicator : MonoBehaviour
{
    public int noteNumber;

    void Update ()
    {
        transform.localScale = Vector3.one * (0.1f + MidiInput.GetKey (noteNumber));
        renderer.material.color = MidiInput.GetKeyDown (noteNumber) ? Color.red : Color.white;
    }
}
