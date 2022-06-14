using UnityEngine;

namespace Installers.Core
{
    public abstract class CastedMonoInstaller<InheritedType, BaseType> : MonoInstaller<BaseType> where InheritedType : BaseType
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<InheritedType> _inputDataInstaller;

        protected override BaseType GetData()
        {
            return (BaseType)_inputDataInstaller.Data;
        }
    }
}