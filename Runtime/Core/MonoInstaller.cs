using UnityEngine;

namespace Installers.Core
{
    public abstract class MonoInstaller<DataType> : MonoInstaller
    {
        private DataType _data;

        public DataType Data { get => _data; }

        public override void Install()
        {
            _data = GetData();

            if (ReferenceEquals(_data, null))
                throw new System.Exception($"Installer error: The MonoInstaller ${gameObject.name} is null");
        }

        protected abstract DataType GetData();
    }

    public abstract class MonoInstaller : MonoBehaviour
    {
        public abstract void Install();
    }
}