using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;

namespace CompositeCommands
{
    public interface IApplicationCommands
    {
        CompositeCommand HiddeCompositeCommand { get; }
        CompositeCommand ShowCompositeCommand { get; }
    }

    public class ApplicationCommands : IApplicationCommands
    {
        private CompositeCommand _hiddeCommand = new CompositeCommand();
        public CompositeCommand HiddeCompositeCommand
        {
            get { return _hiddeCommand; }
        }

        private CompositeCommand _showCommand = new CompositeCommand();
        public CompositeCommand ShowCompositeCommand
        {
            get { return _showCommand; }
        }

    }
}
