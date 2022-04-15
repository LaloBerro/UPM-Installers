using UnityEngine;

namespace Installers.Core
{
    public class InitAInstallerOnAwake : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private MonoInstaller _monoInstaller;

        private void Awake()
        {
            _monoInstaller.Install();
        }
    }
}