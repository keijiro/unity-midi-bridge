using UnityEngine;
using System.Collections;

public class NoteTrigger : MonoBehaviour
{
    public int noteNumber;
    public float velocity;
    public float delay;
    public float interval;

    float scale;

    IEnumerator Start ()
    {
        yield return new WaitForSeconds (2.0f);

        if (delay > 0.0f) {
            yield return new WaitForSeconds (delay);
        }
        while (true) {
            MidiOut.SendNoteOn(0, noteNumber, velocity);
            scale = 2.0f;
            yield return new WaitForSeconds (interval);
            MidiOut.SendNoteOff(0, noteNumber);
        }
    }

    void Update ()
    {
        scale = 1.0f - (1.0f - scale) * Mathf.Exp (Time.deltaTime * -4.0f);
        transform.localScale = Vector3.one * scale;
    }
}
