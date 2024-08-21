using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager chessBoard;
        SocketManager socket;
        #endregion
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            chessBoard = new ChessBoardManager(ChessBoard,PlayerName,Mark);
            chessBoard.EndedGame += ChessBoard_EndedGame;
            chessBoard.PlayerMarked += ChessBoard_PlayerMarked;
            CoolDown.Step = cons.COOL_DOWN_STEP;
            CoolDown.Maximum = cons.COOL_DOWN_TIME;
            CoolDown.Value = 0;
            tmCoolDown.Interval= cons.COOL_DOWN_INTERVAL;
            socket = new SocketManager();
            NewGame();
            

            
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            ChessBoard.Enabled= false;
            undoToolStripMenuItem.Enabled= false;
            //MessageBox.Show("Kết thúc!");
        }

        void NewGame()
        {
            CoolDown.Value = 0;
            tmCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;
            chessBoard.DrawChessBoard();
            
        }

        void Quit()
        {
                Application.Exit();
        }

        void Undo()
        {
            chessBoard.undo();
            CoolDown.Value = 0;
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonEvent e)
        {
            tmCoolDown.Start();
            ChessBoard.Enabled = false;
            CoolDown.Value=0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT,"",e.ClickedPoint));
            undoToolStripMenuItem.Enabled = false;
            Listen();
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            CoolDown.PerformStep();
            if(CoolDown.Value>= CoolDown.Maximum)
            {
                
                EndGame();
                socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            ChessBoard.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
            socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
            ChessBoard.Enabled = true;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình!", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
            else
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            socket.IP = txbIP.Text;
            if (!socket.ConnectServer())
            {
                socket.isServer= true;
                ChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                ChessBoard.Enabled = false;
                Listen();
            }

            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if(string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);

            }
        }

        void Listen()
        {
            
                Thread listenThread = new Thread(() =>
                {
                    try
                    {
                        SocketData data = (SocketData)socket.Receive();
                        ProcessData(data);
                    }
                    catch { }
                    {

                    }
                    
                });
                listenThread.IsBackground = true;
                listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        ChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        CoolDown.Value = 0;
                        ChessBoard.Enabled = true;
                        tmCoolDown.Start();
                        chessBoard.OtherPlayerMark(data.Point);
                        undoToolStripMenuItem.Enabled = true;
                    }));
                    break;
                    
                case (int)SocketCommand.UNDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        Undo();
                        CoolDown.Value = 0;
                    }));
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Đã 5 quân trên một hàng!");
                    break;
                case (int)SocketCommand.TIME_OUT:
                    MessageBox.Show("Hết giờ!");
                    break;
                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Đối phương đã thoát!");
                    break;
                default:
                    break;
            }
            Listen();
        }

        
    }
}
