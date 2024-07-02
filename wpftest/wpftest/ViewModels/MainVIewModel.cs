namespace wpftest.ViewModels;
using System.ComponentModel;
using System.Windows.Input;
using wpftest.Models;

public class MainViewModel : INotifyPropertyChanged
{
    private User user;

    public User User
    {
        get { return user; }
        set
        {
            if (user != value)
            {
                user = value;
                OnPropertyChanged(nameof(User));
            }
        }
    }

    public ICommand UpdateCommand { get; private set; }

    public MainViewModel()
    {
        User = new User { Name = "John Doe", Age = 30 };  // 初始化示例数据
        UpdateCommand = new RelayCommand(UpdateUser);
    }

    private void UpdateUser(object parameter)
    {
        // 这里可以添加更新逻辑，例如保存到数据库
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class RelayCommand : ICommand
{
    private Action<object> execute;
    private Func<object, bool> canExecute;

    public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object parameter)
    {
        return canExecute == null || canExecute(parameter);
    }

    public void Execute(object parameter)
    {
        execute(parameter);
    }

    public event EventHandler CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
}