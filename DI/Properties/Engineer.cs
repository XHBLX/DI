using System;
using Zenject;
namespace DI.Properties
{
    public class Engineer : UnitTestBase
    {
        protected override void SetInstallers()
        {
            installers.Add(new DIinstaller());
        }


        [Inject]
        Ialgo _algo;

        string _name;
        public Engineer()
        {
            _name = _algo.getName();//gets error, _algo is null.
        }


        public string getName()
        {
            return _algo.getName();//gets error here too.

        }
    }

    interface Ialgo
    {
        string getName();
    }

    public class Algo : Ialgo
    {
        String _name;
        public Algo()
        {
            _name = "s";
        }

        public string getName()
        {
            return _name;
        }
    }

}
