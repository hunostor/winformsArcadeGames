using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HungrySnake
{
    public partial class frmSnake : Form
    {
        Random rand;

        enum GameBoardFields
        {
            Free, Snake, Bonus
        };

        enum Directions
        {
            Up, Down, Left, Right
        };

        struct SnakeCoordinates
        {
            public int x;
            public int y;
        };

        GameBoardFields[,] gameBoardField;
        SnakeCoordinates[] snakeXY;
        int snakeLength;
        Directions directions;
        Graphics g;

        public frmSnake()
        {
            InitializeComponent();
            gameBoardField = new GameBoardFields[11, 11];
            snakeXY = new SnakeCoordinates[100];
            rand = new Random();
        }

        private void frmSnake_Load(object sender, EventArgs e)
        {
            picGameBoard.Image = new Bitmap(420, 420);
            g = Graphics.FromImage(picGameBoard.Image);
            g.Clear(Color.White);

            for (int i = 1; i <= 10; i++)
            {
                // top and bottom walls
                g.DrawImage(imgList.Images[6], i*35, 0);
                g.DrawImage(imgList.Images[6], i*35, 385);
            }

            for (int i = 0; i <= 11; i++)
            {
                // left and right walls
                g.DrawImage(imgList.Images[6], 0, i * 35);
                g.DrawImage(imgList.Images[6], 385, i * 35);
            }
        }
    }
}
