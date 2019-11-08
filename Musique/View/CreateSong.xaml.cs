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
using Musique.Service;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Musique.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateSong : Page
    {

        private ISongService _iSongService;



        public  CreateSong()
        {
            Debug.WriteLine("Init Create Song.");
            this.InitializeComponent();
            this._iSongService = new SongService();
        }


        private void CreateMySong(object sender, RoutedEventArgs e)
        {
            var song = new Song
            {
                name = this.SongName.Text,
                description = this.Description.Text,
                singer = this.Singer.Text,
                author = this.Author.Text,
                thumbnail = this.ThumbnailUrl.Text,
                link = this.Link.Text
            };
            var responseMember = this._iSongService.CreateSong(ProjectConfiguration.CurrentMemberCredential, song);
            Debug.WriteLine(responseMember);
            if (responseMember != null && responseMember.id != null)
            {

                Debug.WriteLine("Up song success with name: " + responseMember.id);
                this.Frame.Navigate(typeof(ListSongPage));
            }
            else
            {
                Debug.WriteLine("Up song fails !");
            }
        }
    }
}
