using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard { 
            get => chessBoard;
            set => chessBoard = value; 
        }

        private List<Player> player;
        public List<Player> Player { 
            get => player; 
            set => player = value; 
        }

        private int currentPlayer;
        public int CurrentPlayer { 
            get => currentPlayer; 
            set => currentPlayer = value; 
        }

        private TextBox playerName;
        public TextBox PlayerName { 
            get => playerName; 
            set => playerName = value; 
        }

        private PictureBox playerMark;
        public PictureBox PlayerMark { 
            get => playerMark; 
            set => playerMark = value;
        }

        private List<List<Button>> matrix;
        public List<List<Button>> Matrix { 
            get => matrix; 
            set => matrix = value; 
        }
        

        private event EventHandler<ButtonEvent> playerMarked;

        public event EventHandler<ButtonEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;

        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }

        private Stack<Playinfo> playTimeLine;

        public Stack<Playinfo> PlayTimeLine 
        { 
            get => playTimeLine; 
            set => playTimeLine = value;
        }


        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.chessBoard = chessBoard;
            this.playerName = playerName;
            this.playerMark = mark; 
            this.Player = new List<Player>() {
                new Player("Player1",Image.FromFile("Resources\\X.png")),
                new Player("Player2",Image.FromFile("Resources\\Y.png"))
            };
    
            
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled= true;
            ChessBoard.Controls.Clear();
            PlayTimeLine = new Stack<Playinfo>();
            CurrentPlayer = 0;
            changePlayer();
            Matrix = new List<List<Button>>();
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = cons.CHESS_WIDTH,
                        Height = cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += btn_Click;
                    chessBoard.Controls.Add(btn);

                    Matrix[i].Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;
            mark(btn);

            PlayTimeLine.Push(new Playinfo (getChessPoint(btn),CurrentPlayer));


            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            changePlayer();

            if (playerMarked != null)
                playerMarked(this, new ButtonEvent(getChessPoint(btn)));

            if (isEndGame(btn))
            {
                endGame();
            }
        }

        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];
            if (btn.BackgroundImage != null)
                return;
            mark(btn);

            PlayTimeLine.Push(new Playinfo(getChessPoint(btn), CurrentPlayer));


            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            changePlayer();

            

            if (isEndGame(btn))
            {
                endGame();
            }
        }

        public void endGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
        }

        public bool undo()
        {
            if (PlayTimeLine.Count <= 0)
                return false;
            bool isUndo1 = UndoAStep();
            bool isUndo2 = UndoAStep();
            Playinfo oldPoint = PlayTimeLine.Peek();
            CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            return isUndo1 && isUndo2;
        }

        private bool UndoAStep()
        {
            if (PlayTimeLine.Count <= 0)
                return false;

            Playinfo oldPoint = PlayTimeLine.Pop();
            Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];
            btn.BackgroundImage = null;

            if (PlayTimeLine.Count <= 0)
                CurrentPlayer = 0;
            else
            {
                oldPoint = PlayTimeLine.Peek();
                CurrentPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }
            changePlayer();
            return true;
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point getChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizoncal = Matrix[vertical].IndexOf(btn);
            Point point = new Point(horizoncal,vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = getChessPoint(btn);
            int countLeft = 0;
            for(int i = point.X ;i >= 0 ; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X+1; i <cons.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }
            return countLeft + countRight == 5;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.Y + 1; i < cons.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndPrimary(Button btn)
        {
            Point point = getChessPoint(btn);
            int countTop = 0;   
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= cons.CHESS_BOARD_WIDTH - point.X; i++) {

                if (point.X + i >= cons.CHESS_BOARD_WIDTH || point.Y + i >= cons.CHESS_BOARD_HEIGHT)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndSub(Button btn)
        {
            Point point = getChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i >cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= cons.CHESS_BOARD_WIDTH - point.X; i++)
            {

                if (point.X - i < 0 || point.Y + i >= cons.CHESS_BOARD_HEIGHT)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            return countTop + countBottom == 5;
        }

        private void mark(Button btn ){
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
        }
        private void changePlayer()
        {
            playerName.Text = Player[CurrentPlayer].Name;
            playerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion
    }

    public class ButtonEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }

        public ButtonEvent(Point point)
        {
            this.clickedPoint = point;

        }
    }
}
