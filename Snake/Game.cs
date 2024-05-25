using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Game
    {

        public Keys Direction { get; set; }

        public Keys Arrow { get; set; }

        private System.Windows.Forms.Timer Frame { get; set; }
        private Label LbPontuacao { get; set; }
        private Panel PnTela { get; set; }

        private int pontos = 0;

        private Food Food;

        private Snake Snake;

        private Bitmap offScreenBitmap;

        private Graphics bitmapGraph;

        private Graphics? screenGraph;


        public Game(ref System.Windows.Forms.Timer timer,
                    ref Label label,
                    ref Panel panel)
        {
            PnTela = panel;
            Frame = timer;
            LbPontuacao = label;
            offScreenBitmap = new Bitmap(428, 428);
            Snake = new Snake();
            Food = new Food();
            Direction = Keys.Left;
            Arrow = Direction;
        }


        public void StartGame()
        {
            Snake.Reset();
            Food.CreateFood();
            Direction = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            screenGraph = PnTela.CreateGraphics();
            Frame.Enabled = true;
        }

        public void Tick()
        {
            if (((Arrow == Keys.Left) && (Direction != Keys.Right)) ||
             ((Arrow == Keys.Right) && (Direction != Keys.Left)) ||
             ((Arrow == Keys.Up) && (Direction != Keys.Down)) ||
             ((Arrow == Keys.Down) && (Direction != Keys.Up)))
            {
                Direction = Arrow;
            }

            switch (Direction)
            {
                case Keys.Left:
                    Snake.Left();
                    break;
                case Keys.Right:
                    Snake.Right();
                    break;
                case Keys.Up:
                    Snake.Up();
                    break;
                case Keys.Down:
                    Snake.Down();
                    break;
            }


            bitmapGraph.Clear(Color.Black);
           
            bitmapGraph.DrawImage(Properties.Resources.maça,(Food.Location.X *15), (Food.Location.Y * 15), 15,15);
            bool gameOver = false;


            for (int i = 0; i < Snake.Length; i++)
            {
                if(i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#828282")), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15); //COR CABEÇA DA COBRA
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#FFFFFF")), (Snake.Location[i].X * 15), (Snake.Location[i].Y * 15), 15, 15); //COR DA COBRA
                }

                if ((Snake.Location[i] == Snake.Location[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }

            screenGraph.DrawImage(offScreenBitmap, 0, 0);
            CheckCollision();
            if (gameOver)
            {
                GameOver();
            }
        }

        public void CheckCollision()
        {
            if (Snake.Location[0] == Food.Location) //Logica da cobra comendo
            {
                Snake.Eat();
                Food.CreateFood();
                pontos += 10;
                LbPontuacao.Text = "PONTOS: " + pontos;
            }
        }

        public void GameOver()
        {
            Frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            LbPontuacao.Text = "PONTOS: 0";
            pontos = 0;
            MessageBox.Show("GAME OVER");

        }
    }

        
}