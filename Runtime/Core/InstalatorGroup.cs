using UnityEngine;

namespace Project.Common.ListItems
{
    public class InstalatorGroup : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private Instalator[] _instalators;

        public override void Install()
        {
            foreach (var instalator in _instalators)
            {
                instalator.Install();
            }
        }
    }
}