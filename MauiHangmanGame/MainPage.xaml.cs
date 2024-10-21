using System.ComponentModel;
using System.Diagnostics;

namespace MauiHangmanGame
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region UI Properties
        public string Highlighted
        {
            get => _highlighted;
            set
            {
                _highlighted = value;
                OnPropertyChanged();
            }
        }
        public List<char> Characters
        {
            get => _characters;
            set
            {
                _characters = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        public string GameStatus
        {
            get => _gameStatus;
            set
            {
                _gameStatus = value;
                OnPropertyChanged();
            }
        }
        public string CurrentImage
        {
            get => _currentImage;
            set
            {
                _currentImage = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Fields
        private List<string> words = new List<string>
         {
            "python",
            "javascript",
            "maui",
            "csharp",
            "mongodb",
            "sql",
            "xaml",
            "word",
            "excel",
            "powerpoint",
            "linux",
            "windows",
            "macos"
         };

        private string _answer = "";
        private string _highlighted = null!;

        private List<char> _guess = new List<char>();
        private List<char> _characters = new List<char>();
        private string _message = null!;

        private int _mistakes = 0;
        private int _maxMistakes = 6;

        private string _gameStatus = null!;
        private string _currentImage = "img0.jpg";

        #endregion

        public MainPage()
        {
            InitializeComponent();
            Characters.AddRange("abcdefghijklmnopqrstuvwxyz");
            BindingContext = this;
            ChooseWord();
            CalculateWord(_answer, _guess);
        }

        #region Game
        private void ChooseWord()
        {
            _answer =
                 words[new Random().Next(0, words.Count)];
            Debug.WriteLine(_answer);
        }

        private void CalculateWord(string answer, List<char> guess)
        {
            var temp =
                 answer.Select(x => (guess.IndexOf(x) >= 0 ? x : '_'))
                 .ToArray();

            Highlighted = string.Join(' ', temp);
        }

        private void HandleGuess(char character)
        {
            if (_guess.IndexOf(character) == -1)
            {
                _guess.Add(character);
            }
            if (_answer.IndexOf(character) >= 0)
            {
                CalculateWord(_answer, _guess);
                VerifyWonGame();
            }
            else if (_answer.IndexOf(character) == -1) // mistake
            {
                _mistakes++;
                UpdateStatus();
                VerifyLostGame();
                CurrentImage = $"img{_mistakes}.jpg";
            }
        }

        private void VerifyLostGame()
        {
            if (_mistakes == _maxMistakes)
            {
                Message = "You Lost...";
                DisableCharacters();
            }
        }

        private void DisableCharacters()
        {
            foreach (var children in LetrasContainer.Children)
            {
                var btn = children as Button;
                if (btn != null)
                {
                    btn.IsEnabled = false;
                }
            }
        }
        private void EnableCharacters()
        {
            foreach (var children in LetrasContainer.Children)
            {
                var btn = children as Button;
                if (btn != null)
                {
                    btn.IsEnabled = true;
                }
            }
        }

        private void VerifyWonGame()
        {
            if (Highlighted.Replace(" ", "") == _answer)
            {
                Message = "You Won!!";
                DisableCharacters();
            }
        }

        private void UpdateStatus()
        {
            GameStatus = $"Mistakes: {_mistakes} out of {_maxMistakes}";
        }

        #endregion

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var letra = btn.Text;
                btn.IsEnabled = false;
                HandleGuess(letra[0]);
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            _mistakes = 0;
            _guess = new List<char>();
            CurrentImage = "img0.jpg";
            ChooseWord();
            CalculateWord(_answer, _guess);
            Message = "";
            UpdateStatus();
            EnableCharacters();
        }
    }
}
