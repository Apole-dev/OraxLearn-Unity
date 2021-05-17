using UnityEngine;

namespace OraxLearnUnity.DebugLog
{
    public class DebugLog : MonoBehaviour
    {
        private string _DebugLogTextStart = "Orax.net";
        private string _DebugLogTextUpdate = "Test";
        void Start() => Debug.Log($"<color=red>Color Red {_DebugLogTextStart} :</color>");

        void Update() => Debug.Log(_DebugLogTextUpdate);


        
    }
}

