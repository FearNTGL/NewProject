using BukStat.ViewModel.Base;


namespace BukStat.ViewModel
{
    class MainWindowsViewModel : BaseViewModel
    {
        private string _Title = "BukStat";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);

        }
    }
}
