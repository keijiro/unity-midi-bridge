using UnityEngine;
using System.Collections;

public class KnobIndicator : MonoBehaviour
{
    public static MidiInput.Filter filter = MidiInput.Filter.Realtime;

    public int channel;

    void Start ()
    {
        GetComponentInChildren<TextMesh> ().text = "CC:" + channel;
    }

    void Update ()
    {
        var input = MidiInput.GetKnob (channel, filter);

        var position = transform.localPosition;
        position.y = (input - 0.5f) * 10.0f;
        transform.localPosition = position;
    }
}
