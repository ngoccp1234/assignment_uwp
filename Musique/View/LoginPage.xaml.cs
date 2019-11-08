using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Musique.Entity;
using Musique.View;
using Musique.Service;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Musique.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private  IMemberService _memberService;
        private  IFileService _fileService;
        public LoginPage()
        {
            Debug.WriteLine("Init login.");
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
        }

        private void Btn_Login(object sender, RoutedEventArgs e)
        {
            var memberLogin = new MemberLogin
            {
                email = Email.Text,
                password = Password.Password
            };
            var memberCredential = this._memberService.Login(memberLogin);
            this._fileService.SaveMemberCredentialToFile(memberCredential);

            if (memberCredential?.token != null)
            {
                Debug.WriteLine("Login success with token: " + memberCredential.token);

            }
            else
            {
                Debug.WriteLine("Login fails !");
            }
        }

        private void OrRegister(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegisterPage));
        }
    }
}
