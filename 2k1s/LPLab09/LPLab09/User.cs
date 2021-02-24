using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab09
{
    class User
    {
        public User() { }

        public event MoveDelegate Move;
        delegate bool EmptyCHeck(MoveDelegate md);
        EmptyCHeck IsEmpty = (md) => md == null ? true : false;
        public void MoveFigure(int deltaX, int deltaY)
        {
            Console.WriteLine($"User: Изменяем положение подписанных фигур на delX = {deltaX}, delY = {deltaY}...");
            if(!IsEmpty(Move))
            {
                Move(deltaX, deltaY);
            }
        }

        public event CompressDelegate Compress;

        public void CompressFigure(double k)
        {
            Console.WriteLine($"User: Сжимаем подписанные объекты с k = {k}...");
            if (Compress != null)
            {
                Compress(k);
            }
        }
    }
}
