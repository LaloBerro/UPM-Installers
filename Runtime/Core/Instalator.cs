using UnityEngine;

namespace Installers.Core
{
    public class Instalator : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private MonoInstaller[] _monoInstallers;

        [Header("Config")]
        [SerializeField] private bool _isDebugActivated;

        public override void Install()
        {
            foreach (var monoInstaller in _monoInstallers)
            {
                if (null == monoInstaller)
                    throw new System.Exception("The MonoInstaller is null on " + gameObject.name);

                if (_isDebugActivated)
                    Debug.Log(monoInstaller.gameObject.name);

                monoInstaller.Install();
            }
        }
    }
}