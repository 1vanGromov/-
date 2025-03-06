using ReactiveUI;
using AvaliniaEnd.Models;
namespace AvaliniaEnd.ViewModels;

public class ViewModelBase : ReactiveObject
{
    public PostgresContext db = new PostgresContext();
}
