using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DisplayTweets
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string getTweets(string searchValue)
        {
            WebClient client = new WebClient();
            byte[] rawBytes = client.DownloadData("http://feeds.incrowdsports.com/twitter/tweets/search?value=" + searchValue);
            return Encoding.UTF8.GetString(rawBytes);
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = inputBox.Text.Replace("#", "%23");
            string texts = getTweets(userInput);
            string[] tokens = texts.Split(new string[] { "\"text\":\"", "\",\"timeline\":", "\",\"profileImageURL\":\"", "\",\"followersCount\":" }, StringSplitOptions.None);
            if (tokens.Length > 4) { 
                List<Tweet> tweets = new List<Tweet>();
                for (int i = 1; i < tokens.Length; i += 4)
                {
                    Tweet tweet = new Tweet() { AvatarSource = tokens[i + 2], TweetText = tokens[i] };
                    if (!tweets.Contains(tweet))
                    {
                        tweets.Add(tweet);
                    }
                }
                if (tweets.Count > 0)
                {
                    tweetsList.ItemsSource = tweets;
                } else
                {
                    MessageBox.Show("No matching tweets with words/phrases: " + userInput);
                }
            } else
            {
                MessageBox.Show("Cannot retrieve tweets from the feed");
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string filename = fileNameBox.Text + ".txt";
            List<Tweet> selectedTweets = new List<Tweet>();
            if (tweetsList.SelectedItems.Count > 0)
            {
                foreach (Tweet item in tweetsList.SelectedItems)
                {
                    selectedTweets.Add(item);
                }

                string[] tweets = new string[selectedTweets.Count];
                for (int i = 0; i < selectedTweets.Count; i++)
                {
                    tweets[i] = selectedTweets[i].TweetText;
                }
                string filepath = "C:\\Users\\Public\\Documents\\" + filename;
                File.WriteAllLines(@filepath, tweets);
                fileNameBox.Text = "";
                MessageBox.Show("Selected Tweets saved to Text files as " + filepath);
            } else
            {
                MessageBox.Show("There are no tweets selected");
            }
        }
    }
}
