using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Commands
{
    interface ICommand
    {
        public void Run();
        public string GetName();
        public string GetDescription();
    }
}
