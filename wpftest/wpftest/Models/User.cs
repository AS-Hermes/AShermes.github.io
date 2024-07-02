namespace wpftest.Models;
using System.ComponentModel;

public class User : INotifyPropertyChanged
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (age != value)
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
