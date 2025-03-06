using System;
using System.Collections.Generic;
using AvaliniaEnd.Models;
using System.Linq;
using ReactiveUI;
using System.Reactive;

namespace AvaliniaEnd.ViewModels
{
	public class LoginViewModel : ViewModelBase
	{
        private  User User1;
        private int idUser;
        private string password1;
        public MainWindowViewModel _MVM;
        public ReactiveCommand<Unit, Unit> LoginCom { get; }

        public LoginViewModel(MainWindowViewModel MVM)
        {
            _MVM = MVM;
           
            LoginCom = ReactiveCommand.Create(UserData);
            Captcha_gen = GenerateRandomText(5);
        } 
       
        public int IdUser { get => idUser; set => this.RaiseAndSetIfChanged(ref idUser, value); }
        public string Password1 { get => password1; set => this.RaiseAndSetIfChanged(ref password1, value); }

        public void UserData( )
        {
            User user = db.Users.FirstOrDefault(x => x.UserId == IdUser && x.Password == Password1);
            if (user != null&& Captcha.Equals(Captcha_gen, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Успешно");
                _MVM.CurrentView = new OrganizatorViewModel(_MVM, user);

            }
            else Console.WriteLine("Не удалось войти");
        }
        public string captcha_gen;
        public string Captcha_gen { get => captcha_gen; set => this.RaiseAndSetIfChanged(ref captcha_gen, value); }

        public string captcha;
        public string Captcha { get => captcha; set => this.RaiseAndSetIfChanged(ref captcha, value); }

        private static Random random = new Random();

        private static string GenerateRandomText(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}