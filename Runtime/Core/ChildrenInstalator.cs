namespace Installers.Core
{
    public class ChildrenInstalator : MonoInstaller
    {
        private MonoInstaller[] _monoInstallers;

        public override void Install()
        {
            _monoInstallers = GetComponentsInChildren<MonoInstaller>();

            foreach (var monoInstaller in _monoInstallers)
            {
                if (null == monoInstaller)
                    throw new System.Exception("The MonoInstaller is null on " + gameObject.name);

                monoInstaller.Install();
            }
        }
    }
}