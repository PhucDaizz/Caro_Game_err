﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caro
{
    internal class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard) 
        {
            this.chessBoard = chessBoard;
        }
        #endregion

        #region Methods
        public void DrawGameBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Constance.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Constance.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Constance.CHESS_WIDTH,
                        Height = Constance.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                    };

                    chessBoard.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Constance.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        #endregion
    }
}