using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TopGoers.ViewModel
{
    //public partial class MainViewMaster
    //{
        public class MainViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainViewMenuItem> MenuItems { get; set; }
            
            public MainViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainViewMenuItem>(new[]
                {
                    new MainViewMenuItem { Id = 0, Title = "Home" },
                    new MainViewMenuItem { Id = 1, Title = "Meus pedidos" },
                    new MainViewMenuItem { Id = 2, Title = "Configurações" },
                    new MainViewMenuItem { Id = 3, Title = "Seja um parceiro" },
                    new MainViewMenuItem { Id = 4, Title = "Contato" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    //}
}