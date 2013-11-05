using UnityEngine;
using System.Collections.Generic;

public class KnobIndicatorGroup : MonoBehaviour
{
    public GameObject prefab;
    public GUIStyle labelStyle;

    List<KnobIndicator> indicators;

    void Start ()
    {
        indicators = new List<KnobIndicator> ();
    }

    void Update ()
    {
        var channels = MidiInput.KnobChannels;

        // If a new chennel was added...
        if (indicators.Count != channels.Length) {
            // Instantiate the new indicator.
            var go = Instantiate (prefab, Vector3.right * indicators.Count, Quaternion.identity) as GameObject;

            // Initialize the indicator.
            var indicator = go.GetComponent<KnobIndicator> ();
            indicator.channel = channels [indicators.Count];

            // Add it to the indicator list.
            indicators.Add (indicator);
        }

        // Change the filter mode on a mouse click.
        if (Input.GetMouseButtonDown (0)) {
            KnobIndicator.filter = (MidiInput.Filter)(((int)KnobIndicator.filter + 1) % 3);
        }
    }

    void OnGUI ()
    {
        var text = "Click the screen to change the filter mode.\n";
        text += "Current mode: " + KnobIndicator.filter;
        GUI.Label (new Rect (0, 0, Screen.width, Screen.height), text, labelStyle);
    }
}
