using UnityEngine;

namespace Installers.Core
{
    public class Instalator : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private MonoInstaller[] _monoInstallers;

        public override void Install()
        {
            foreach (var monoInstaller in _monoInstallers)
            {
                if (null == monoInstaller)
                    throw new System.Exception("The MonoInstaller is null on " + gameObject.name);

                monoInstaller.Install();
            }
        }
    }
}