

namespace TicTacToe
{

    public enum XOE
    {
        E, X, O, D
    }

    public class XOBoard
    {
        int size;
        XOE[,] board;
        int[,] optionalWin;

        int count = 0;
        public XOBoard(int size)
        {
            this.size = size;
            this.board = new XOE[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.board[i, j] = XOE.E;
                }
            }
        }

        public bool Put(XOE choice, int i, int j)
        {
            if (this.board[i, j] != XOE.E)
            {
                return false;
            }
            this.board[i, j] = choice;
            this.count++;
            return true;

        }

        public XOE? Status()
        {
            var success = 0;
            for (int i = 0; i < this.size; i++)
            {
                success = 1;
                for (int j = 1; j < this.size; j++)
                {
                    if (this.board[i, 0] != this.board[i, j])
                    {
                        break;
                    }
                    success++;
                }
                if (success == this.size)
                {
                    return this.board[i, 0];
                }
            }


            for (int i = 0; i < this.size; i++)
            {
                success = 1;
                for (int j = 1; j < this.size; j++)
                {
                    if (this.board[0, i] != this.board[j, i])
                    {
                        break;
                    }
                    success++;
                }
                if (success == this.size)
                {
                    return this.board[0, i];
                }
            }
            success = 1;
            for (int i = 1; i < this.size; i++)
            {

                if (this.board[0, 0] != this.board[i, i])
                {
                    break;
                }
                success += 1;

            }
            if (success == this.size)
            {
                return this.board[0, 0];
            }

            success = 1;
            for (int j = this.size - 2, i = 1; j > 0; j--, i++)
            {
                if (this.board[0, this.size - 1] != this.board[i, j])
                {
                    break;
                }
                success += 1;
            }

            if (success == this.size)
            {
                return this.board[0, this.size - 1];
            }

            if (this.count == this.size * this.size)
            {
                return XOE.D;
            }

            return null;
        }
        public void draw()
        {
            
        }

    }


}