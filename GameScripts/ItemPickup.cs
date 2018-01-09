using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
	private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
	private SteamVR_TrackedObject trackedObj;

	private GameObject obj;
	private FixedJoint fJoint;

	void Start()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		fJoint = GetComponent<FixedJoint>();
	}
    void OnTriggerExit(Collider other)
	{
        obj = null;
	}		
}