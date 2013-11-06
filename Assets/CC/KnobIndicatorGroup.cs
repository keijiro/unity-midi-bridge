using UnityEngine;
using System.Collections.Generic;

public class KnobIndicatorGroup : MonoBehaviour
{
    public GameObject prefab;
    public GUIStyle labelStyle;
    public MidiChannel channel = MidiChannel.All;
	public float sensibility = 20.0f;
	
    List<KnobIndicator> indicators;

    void Start ()
    {
        indicators = new List<KnobIndicator> ();
    }

    void Update ()
    {
        var knobNumbers = MidiInput.GetKnobNumbers (channel);

        // If a new chennel was added...
        if (indicators.Count != knobNumbers.Length) {
            // Instantiate the new indicator.
            var go = Instantiate (prefab, Vector3.right * indicators.Count, Quaternion.identity) as GameObject;

            // Initialize the indicator.
            var indicator = go.GetComponent<KnobIndicator> ();
            indicator.channel = channel;
            indicator.knobNumber = knobNumbers [indicators.Count];

            // Add it to the indicator list.
            indicators.Add (indicator);
        }

		MidiInput.knobSensibility = sensibility;
    }
}
