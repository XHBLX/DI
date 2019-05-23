using System;
using Zenject;
namespace DI.Properties
{
    public class DIinstaller : BindingInstaller
    {

        public override void Bind()
        {
            ContainerBindInterfaceTo<Ialgo, Algo>(true);
        }
    }
}
