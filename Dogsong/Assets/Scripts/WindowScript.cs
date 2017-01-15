using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace VRStandardAssets.Utils
{
	// This class works similarly to the SelectionRadial class except
	// it has a physical manifestation in the scene.  This can be
	// either a UI slider or a mesh with the SlidingUV shader.  The
	// functions as a bar that fills up whilst the user looks at it
	// and holds down the Fire1 button.
	public class WindowScript : MonoBehaviour
	{
		public event Action OnBarFilled;                                    // This event is triggered when the bar finishes filling.


		[SerializeField] private float m_Duration = 2f;                     // The length of time it takes for the bar to fill.
		[SerializeField] private VRInteractiveItem m_InteractiveItem;       // Reference to the VRInteractiveItem to determine when to fill the bar.
		[SerializeField] private VRInput m_VRInput;                         // Reference to the VRInput to detect button presses.


		private bool m_BarFilled;                                           // Whether the bar is currently filled.
		private bool m_GazeOver;                                            // Whether the user is currently looking at the bar.
		private float m_Timer;                                              // Used to determine how much of the bar should be filled.
		private Coroutine m_FillBarRoutine;                                 // Reference to the coroutine that controls the bar filling up, used to stop it if required.


		private const string k_SliderMaterialPropertyName = "_SliderValue"; // The name of the property on the SlidingUV shader that needs to be changed in order for it to fill.


		private void OnEnable ()
		{

			m_InteractiveItem.OnOver += HandleOver;
		}
			

		private void Update ()
		{

		}


		private void HandleOver ()
		{
			// The user is now looking at the bar.
			m_GazeOver = true;
			Debug.Log ("IsOver");
			Renderer Rend = GetComponent<Renderer> ();
			Rend.material.shader = Shader.Find ("Specular");
				Rend.material.SetColor("_SpecColor",Color.red);	

		}
	}
}