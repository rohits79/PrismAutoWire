using Microsoft.Practices.Prism.Mvvm;

namespace MainModule.ViewModels
{
    public class ToolbarWindowViewModel : BindableBase
    {
        public ToolbarWindowViewModel()
        {
            Name = "Rohit";
        }
        public string Name { get; set; }
    }
}
