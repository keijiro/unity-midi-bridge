using UnityEngine;
using System.Collections;

public class KnobIndicator : MonoBehaviour
{
    public MidiChannel channel = MidiChannel.All;
    public int knobNumber;

    void Start ()
    {
        GetComponentInChildren<TextMesh> ().text = "CC:" + knobNumber;
    }

    void Update ()
    {
        var input = MidiInput.GetKnob (channel, knobNumber);
        var position = transform.localPosition;
        position.y = (input - 0.5f) * 10.0f;
        transform.localPosition = position;
    }
}
