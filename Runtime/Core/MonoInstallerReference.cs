using UnityEngine;

namespace Installers.Core
{
    public class MonoInstallerReference : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private MonoInstaller _monoInstaller;

        public override void Install()
        {
            if (null == _monoInstaller)
                throw new System.Exception("The MonoInstaller is null on " + gameObject.name);

            _monoInstaller.Install();
        }
    }
}